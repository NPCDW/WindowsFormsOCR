using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOCR
{
    internal class HotKeysUtil
    {
        public static IntPtr mainFormHandle;

        public static byte GetWordsTranslateModifiers;
        public static int GetWordsTranslateKey;
        public static byte OcrModifiers;
        public static int OcrKey;
        public static byte ScreenshotTranslateModifiers;
        public static int ScreenshotTranslateKey;

        public static void RegisterHotKey(IntPtr mainFormHandle)
        {
            HotKeysUtil.mainFormHandle = mainFormHandle;

            HotKeysUtil.GetWordsTranslateModifiers = GlobalConfig.HotKeys.GetWordsTranslate.Modifiers;
            HotKeysUtil.GetWordsTranslateKey = GlobalConfig.HotKeys.GetWordsTranslate.Key;
            HotKeysUtil.OcrModifiers = GlobalConfig.HotKeys.Ocr.Modifiers;
            HotKeysUtil.OcrKey = GlobalConfig.HotKeys.Ocr.Key;
            HotKeysUtil.ScreenshotTranslateModifiers = GlobalConfig.HotKeys.ScreenshotTranslate.Modifiers;
            HotKeysUtil.ScreenshotTranslateKey = GlobalConfig.HotKeys.ScreenshotTranslate.Key;

            NativeMethod.RegisterHotKey(mainFormHandle, 845, GlobalConfig.HotKeys.GetWordsTranslate.Modifiers, GlobalConfig.HotKeys.GetWordsTranslate.Key);
            NativeMethod.RegisterHotKey(mainFormHandle, 846, GlobalConfig.HotKeys.Ocr.Modifiers, GlobalConfig.HotKeys.Ocr.Key);
            NativeMethod.RegisterHotKey(mainFormHandle, 847, GlobalConfig.HotKeys.ScreenshotTranslate.Modifiers, GlobalConfig.HotKeys.ScreenshotTranslate.Key);
        }

        public static void UnRegisterHotKey()
        {
            NativeMethod.UnregisterHotKey(mainFormHandle, 845);
            NativeMethod.UnregisterHotKey(mainFormHandle, 846);
            NativeMethod.UnregisterHotKey(mainFormHandle, 847);
        }

        public static void ReRegisterHotKey()
        {
            if (GlobalConfig.HotKeys.GetWordsTranslate.Key != 0 && (GetWordsTranslateModifiers != GlobalConfig.HotKeys.GetWordsTranslate.Modifiers || GetWordsTranslateKey != GlobalConfig.HotKeys.GetWordsTranslate.Key))
            {
                NativeMethod.UnregisterHotKey(mainFormHandle, 845);
                NativeMethod.RegisterHotKey(mainFormHandle, 845, GlobalConfig.HotKeys.GetWordsTranslate.Modifiers, GlobalConfig.HotKeys.GetWordsTranslate.Key);
            }
            if (GlobalConfig.HotKeys.Ocr.Key != 0 && (OcrModifiers != GlobalConfig.HotKeys.Ocr.Modifiers || OcrKey != GlobalConfig.HotKeys.Ocr.Key))
            {
                NativeMethod.UnregisterHotKey(mainFormHandle, 846);
                NativeMethod.RegisterHotKey(mainFormHandle, 846, GlobalConfig.HotKeys.Ocr.Modifiers, GlobalConfig.HotKeys.Ocr.Key);
            }
            if (GlobalConfig.HotKeys.ScreenshotTranslate.Key != 0 && (ScreenshotTranslateModifiers != GlobalConfig.HotKeys.ScreenshotTranslate.Modifiers || ScreenshotTranslateKey != GlobalConfig.HotKeys.ScreenshotTranslate.Key))
            {
                NativeMethod.UnregisterHotKey(mainFormHandle, 847);
                NativeMethod.RegisterHotKey(mainFormHandle, 847, GlobalConfig.HotKeys.ScreenshotTranslate.Modifiers, GlobalConfig.HotKeys.ScreenshotTranslate.Key);
            }
        }

    }
}
