using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vibration_Analisys2 {
    internal static class StepsInfo {
        public static string Step1 { get; } = "Загрузка данных из Excel и выбор эталонной и второй аварий";
        public static string Step2 { get; } = "Определение максимально допустипого сигнала, при котором наблюдается нормальная работа и\nподсчет надежности для каждого значения вибросигнала";
        public static string Step3 { get; } = "Нахождение отсечки, с которой будем рассматривать вторую аварию";
        public static string Step4 { get; } = "Нахождение наилучшего полинома для выражения второй аварии через значения эталонной аварии";
        public static string Step5 { get; } = "Сравнение коэффициентов надежности предсказанной и реальной аварий";
    }
}
