Kocaeli Üniversitesi Yazılım Lab - 3. Proje

# YUV-Raw-Data Çözücü
Proje: YUV (Raw Data) Çözücü

YUV renk formatı, RGB renk uzayına alternatif olarak önerilmiş bir renk uzayıdır.  Y bileşeni ışıklılık bileşenine, U (Cb) ve V (Cr) ise renk bileşenlerine karşılık gelmektedir. Y ve U-V bileşenleri, ışıklılık ve renk kanalları olarak da bilinmektedir.  RGB renk uzayında bir piksel ortalama 24 bit ile ifade edilirken, YUV renk uzayında piksel başına ortalama 24 bitten daha az sayıda bit kullanılabilmektedir. Bunun nedeni, U ve V kanallarında Y kanalına göre daha az sayıda piksel içermesidir. Literatürde farklı örnekleme türleriyle hazırlanmış YUV formatları bulunmaktadır. Örneğin;
•	4:4:4 formatı: Renk kanallarında (Chroma kanallarında, Cr-Cb) herhangi bir alt örnekleme yapılmamıştır.
•	4:2:2 formatı: Renk kanallarında, ½ oranında yatay alt-örnekleme yapıldığı, düşeyde ise herhangi bir alt-örnekleme yapılmadığı duruma karşılık gelmektedir. 
•	4:2:0 formatı:  Renk kanallarında, ½ oranında yatay alt-örnekleme ve düşey alt-örnekleme yapıldığı durumdur.

Projede sizden istenenler aşağıda listelenmiştir:

•	Arayüz tasarımı: Tasarlanacak arayüz üzerinden dosya okuma, .bmp kaydetme, görüntü oynatma ve ayarlar seçeneği olacaktır.
•	Dosya okuma: .yuv uzantılı dosyalar okunacak ve render/parse işlemine tabii tutulacaktır.
•	Ayarlar:  Hangi formatta okuma işlemi yapılacağı ve görüntülerin en/boy bilgisinin ayarlandığı bölüm olacaktır.
•	.bmp kaydetme: Parse işlemi sonrası tüm görüntü çerçevelerinin sadece Y bileşenleri numaralandırılarak kaydedilecektir. 
•	Görüntü oynatma/gösterme: Parse işlemi sonrası sadece Y bileşenleri, tasarlanacak arayüz üzerinde oynatılacaktır. Oynatma işlemi, çerçeve bazlı yapılacaktır. 

#Kocaeli University Software Lab - 3rd Project

# YUV-Raw-Data Solver
Project: YUV (Raw Data) Solver

The YUV color format is a proposed color space as an alternative to the RGB color space. The Y component corresponds to the luminance component, and the U (Cb) and V (Cr) components to the color components. Y and U-V components are also known as luminance and color channels. While a pixel in RGB color space is expressed with an average of 24 bits, less than 24 bits per pixel can be used in YUV color space. This is because the U and V channels contain fewer pixels than the Y channel. There are YUV formats prepared with different sampling types in the literature. E.g;
• 4:4:4 format: No downsampling is done in the color channels (Chroma channels, Cr-Cb).
• 4:2:2 format: Corresponds to the case where color channels are downsampled horizontally at a ½ ratio, while vertically there is no downsampling.
• 4:2:0 format: When color channels are horizontally downsampled and vertical downsampled at a ratio of ½.

Listed below are the requests from you in the project:

• Interface design: There will be options for reading files, recording .bmp, playing images and settings over the interface to be designed.
• File reading: Files with .yuv extension will be read and rendered/parseed.
• Settings: It will be the section in which format to read and the aspect/length information of the images are adjusted.
• .bmp saving: After parsing, only the Y components of all image frames will be saved by numbering.
• Image playback/showing: Only Y components will be played on the interface to be designed after the parse process. Playback will be frame-based.
