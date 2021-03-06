由于 `WindowsForms` 平台的限制，导致用户体验非常差，此项目不得不告一段落，已经使用 `WPF` 重写此项目 [https://github.com/NPCDW/WpfTool](https://github.com/NPCDW/WpfTool)

受限制的问题主要有两块

1. `WindowsForms` 采用 `CPU` 进行渲染计算，而非 `GPU` ，在截屏时会有非常明显的卡顿现象
2. `WindowsForms` 不支持控件的矢量布局，如果不使用 `DPI` 适应，窗口和字体会变得非常模糊，如果使用，系统超过 `100%` 的缩放窗口控件布局就会挤在一起
3. `WindowsForms` 也没有漂亮的 UI 框架


此项目调用 `TencentCloud` 和 `BaiduCloud` 实现的 `OCR` 以及翻译

* 支持截图文字识别
* 支持划词翻译
* 支持截图翻译

截图是使用 `Graphics` 进行绘制的，会有明显的卡顿感觉

划词（屏幕取词）是采用模拟发送 `Ctrl+C` ，然后再从剪切板取词
