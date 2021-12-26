#Kocaeli Üniversitesi Yazılım Lab - 3. Proje

# YUV-Raw-Data COZUCU
Proje: YUV (Raw Data) ÇÖZÜCÜ

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
