﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using FirstFloor.ModernUI.Helpers;
using FirstFloor.ModernUI.Windows.Controls;
using JetBrains.Annotations;

namespace FirstFloor.ModernUI.Dialogs {
    public static class ErrorMessage {
        public static void Show(NonfatalErrorEntry entry) {
            var text = (entry.Exception == null ? $"{entry.DisplayName}." : $"{entry.DisplayName}:\n\n[b][mono]{entry.Exception.Message}[/mono][/b]") +
                    (entry.Commentary == null ? "" : $"\n\n[i]{entry.Commentary}[/i]");
            var dlg = new ModernDialog {
                Title = UiStrings.Common_Oops,
                Content = new ScrollViewer {
                    Content = new BbCodeBlock { BbCode = text, Margin = new Thickness(0, 0, 0, 8) },
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled
                },
                MinHeight = 0,
                MinWidth = 0,
                MaxHeight = 480,
                MaxWidth = 640
            };

            dlg.Buttons = entry.Solutions.Select(x => dlg.CreateFixItButton(x, entry)).Where(x => x != null).Union(new[] { dlg.OkButton });
            dlg.Show();

            entry.Unseen = false;
        }

        [CanBeNull]
        public static Button CreateFixItButton([NotNull] this ModernDialog dlg, [CanBeNull] INonfatalErrorSolution solution, NonfatalErrorEntry entry = null) {
            if (dlg == null) throw new ArgumentNullException(nameof(dlg));
            if (solution == null || !solution.CanBeApplied) return null;
            return dlg.CreateCloseDialogButton(solution.DisplayName ?? "Fix It", false, false, MessageBoxResult.OK, () =>
                    solution.Solve(entry).Forget());
        }
    }
}