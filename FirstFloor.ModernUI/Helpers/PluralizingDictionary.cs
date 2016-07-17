using JetBrains.Annotations;

namespace FirstFloor.ModernUI.Helpers {
    // Localize me!
    internal static class PluralizingDictionary {
        [CanBeNull]
        public static string PluralizeEn(string s) {
            switch (s) {
                case "child": return "children";
                case "person": return "people";
                case "man": return "men";
            }

            if (s.EndsWith("o")) {
                return null;
            }

            if (s.EndsWith("s") || s.EndsWith("x") || s.EndsWith("ch") || s.EndsWith("sh")) {
                return s + "es";
            }

            if (s.EndsWith("y")) {
                return s.Substring(0, s.Length - 1) + "ies";
            }

            return s + "s";
        }

        [CanBeNull]
        public static string PluralizeRu(string s, bool two) {
            switch (s) {
                case "����": return two ? "�����" : "������";
                case "��������": return two ? "���������" : "����������";
                case "���������": return two ? "����������" : "�����������";
                case "���-����": return two ? "���-�����" : "���-������";
                case "������": return two ? "�������" : "��������";
            }

            return null;
        }
    }
}