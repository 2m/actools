using System;
using AcTools.Render.Base.Cameras;
using AcTools.Render.Base.TargetTextures;
using AcTools.Render.Shaders;
using AcTools.Utils;
using SlimDX;
using SlimDX.Direct3D11;

namespace AcTools.Render.Base.PostEffects.AO {
    public class SsaoAltHelper : AoHelperBase {
        private EffectPpSsaoAlt _effect;

        public override void OnInitialize(DeviceContextHolder holder) {
            base.OnInitialize(holder);

            _effect = holder.GetEffect<EffectPpSsaoAlt>();

            var samplesKernel = new Vector4[EffectPpSsao.SampleCount];
            var random = new Random(0);
            for (var i = 0; i < samplesKernel.Length; i++) {
                samplesKernel[i].X = (float)(random.NextDouble() * 2d - 1d);
                samplesKernel[i].Z = (float)(random.NextDouble() * 2d - 1d);
                samplesKernel[i].Y = (float)random.NextDouble();
                samplesKernel[i].Normalize();

                var scale = (float)i / samplesKernel.Length;
                scale = (scale * scale).Lerp(0.1f, 1f);
                samplesKernel[i] *= scale;
            }

            _effect.FxSamplesKernel.Set(samplesKernel);
        }

        public override void Draw(DeviceContextHolder holder, ShaderResourceView depth, ShaderResourceView normals, ICamera camera,
                TargetResourceTexture target, float aoPower, float aoRadiusMultiplier, bool accumulationMode) {
            SetBlurEffectTextures(depth, normals);
            SetRandomValues(holder, _effect.FxNoiseMap, _effect.FxNoiseSize, accumulationMode, target.Size);

            holder.DeviceContext.Rasterizer.SetViewports(target.Viewport);
            holder.DeviceContext.OutputMerger.SetTargets(target.TargetView);
            holder.PrepareQuad(_effect.LayoutPT);
            _effect.FxDepthMap.SetResource(depth);
            _effect.FxNormalMap.SetResource(normals);

            _effect.FxAoPower.Set(aoPower * 1.2f);
            _effect.FxAoRadius.Set(aoRadiusMultiplier * 0.8f);
            _effect.FxViewProj.SetMatrix(camera.ViewProj);
            _effect.FxViewProjInv.SetMatrix(camera.ViewProjInvert);

            _effect.TechSsaoVs.DrawAllPasses(holder.DeviceContext, 6);
        }
    }
}