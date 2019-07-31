快速上手：

	1.	安装VS2012环境安装包(vcredist_x86_vs2012.exe)、VS2013环境安装包（vcredist_x86_vs2013.exe）
	
	2.	从官网申请sdk  http://www.arcsoft.com.cn/ai/arcface.html  ，下载对应的sdk版本(x86或x64)并解压
	
	3.	将libs中的“libarcsoft_face.dll”、“libarcsoft_face_engine.dll”拷贝到工程bin目录的对应平台的debug或release目录下
	
	4.	将对应appid和appkey替换App.config文件中对应内容
	
	5.	在Debug或者Release中选择配置管理器，选择对应的平台
	
	6.	按F5启动程序
	
	7.	点击“注册人脸”按钮增加人脸库图片
	
	8.	点击“选择识别图”按钮增加人脸图片
	
	9.	点击“开始匹配”按钮进行比较
	
	10.	根据下面文本框查看相关信息 


常见问题：

	1.后引擎初始化失败	
		(1)请选择对应的平台，如x64,x86 
		(2)删除bin下面对应的asf_install.dat，freesdk_132512.dat；
		(3)请确保App.config下的appid，和appkey与当前sdk一一对应。
		
	2.SDK支持那些格式的图片人脸检测？	
		目前SDK支持的图片格式有jpg，jpeg，png，bmp等。
		
	3.使用人脸检测功能对图片大小有要求吗？	
		推荐的图片大小最大不要超过2M，因为图片过大会使人脸检测的效率不理想，当然图片也不宜过小，否则会导致无法检测到人脸。
		
	4.使用人脸识别引擎提取到的人脸特征信息是什么？	
		人脸特征信息是从图片中的人脸上提取的人脸特征点，是byte[]数组格式。 
		
	5.SDK人脸比对的阈值设为多少合适？	
		推荐值为0.8，用户可根据不同场景适当调整阈值。
		
	6.可不可以将人脸特征信息保存起来，等需要进行人脸比对的时候直接拿保存好的人脸特征进行比对？
		可以，当人脸个数比较多时推荐先存储起来，在使用时直接进行比对，这样可以大大提高比对效率。存入数据库时，请以Blob的格式进行存储，不能以string或其他格式存储。
		
	7.在.Net项目中出现堆栈溢出问题,如何解决？
		.Net平台设置的默认堆栈大小为256KB，SDK中需要的大小为512KB以上，推荐调整堆栈的方法为：
		new Thread(new ThreadStart(delegate {
			ASF_MultiFaceInfo multiFaceInfo = FaceUtil.DetectFace(pEngine, imageInfo);
		}), 1024 * 512).Start();
		
	8.X86模式下批量注册人脸有内存溢出或图片空指针	
		请增加虚拟内存或每次批量注册人脸控制在20张图片范围内
		
	9.图片中有人脸，但是检测时未检测到人脸	
		(1)请调整detectFaceScaleVal的值；
		(2)请确认图片的宽度是否为4的倍数；
		(3)请确认图片是否通过ImageUtil.ReadBMP方法进行数据调整。
