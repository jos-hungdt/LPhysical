CREATE DATABASE LPHYSIC
GO
USE LPHYSIC
GO
CREATE TABLE TENBASE(
STT INT IDENTITY(1,1) PRIMARY KEY ,
BAI NVARCHAR(20) NOT NULL,
NAME NVARCHAR(100),
CONTENT VARCHAR(20)
)
GO
CREATE TABLE ELEVEN(
STT INT IDENTITY(1,1) PRIMARY KEY,
BAI NVARCHAR(20) NOT NULL,
NAME NVARCHAR(100),
CONTENT VARCHAR(20)
)
GO
CREATE TABLE TWENTH(
STT INT IDENTITY(1,1) PRIMARY KEY,
BAI VARCHAR(20) NOT NULL,
NAME NVARCHAR(100),
CONTENT VARCHAR(20)
)
CREATE TABLE TEST(
STT INT IDENTITY(1,1),
MON VARCHAR(20) NOT NULL,
LOAIDE VARCHAR(20),
CONTENT TEXT,
DIEM FLOAT
)
DROP TABLE TWENTH
SELECT * FROM TWENTH

INSERT INTO TWENTH VALUES (N'Bài 1',N'Dao động cơ','bai1lop12.html')
INSERT INTO TWENTH VALUES (N'Bài 2',N'Con lắc lò xo','bai2lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 3',N'Con lắc đơn','bai3lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 4',N'Dao động tắt dần. Dao động cưỡng bức','bai4lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 5',N'Tổng hợp hai dao động điều hòa cùng phương , cùng tần số  Phương pháp giản đồ Fre-nen','bai5lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 6',N'Thực hành: Khảo sát thực nghiệm các định luật dao động của con lắc đơn','bai6lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 7',N'Sóng cơ và sự truyền sóng cơ','bai7lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 8',N'Giao thoa sóng','bai8lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 9',N'Sóng dừng','bai9lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 10',N'Đặc trưng vât lý của âm','bai10lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 11',N'Đặc trưng sinh lí của âm','bai11lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 12',N'Đại cương về dòng điện xoay chiều','bai12lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 13',N'Các mạch điện xoay chiều','bai13lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 14',N'Mạch có R, L, C mắc nối tiếp','bai14lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 15',N'Công suất điện tiêu thụ của mạch điện xoay chiều. Hệ số công  suất','bai15lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 16',N'Truyền tải điện năng. Máy biến áp','bai16lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 17',N'Máy phát điện xoáy chiều','bai17lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 18',N'Động cơ không đồng bộ ba pha','bai18lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 19',N'Thực hành : Khảo sát đoạn mạch điện xoay chiều có R, L< C mắc nối tiếp','bai19lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 20',N'Mạch dao động','bai20lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 21',N'Điện từ trường','bai21lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 22',N'Sóng điện từ’,’bai22lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 23',N'Nguyên tắc thông tin liên lạc bằng sóng vô tuyến','bai23lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 24',N'Tán sắc ánh sáng','bai24lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 25',N'Giao thoa ánh sáng','bai25lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 26',N'Các loại quang phổ','bai26lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 27',N'Tia hồng ngoại và tia tử ngoại','bai27lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 28',N'Tia X','bai28lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 29',N'Thực hành: Đo bước sóng ánh sang bằng phương pháp giao thoa','bai29lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 30',N'Hiện tương quang điện. Thuyết lượng tử ánh sáng','bai30lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 31',N'Hiện tượng quang điện trong','bai31lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 32',N'Hiện tượng quang – phát quang','bai32lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 33',N'Mẫu nguyên tử Bo','bai33lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 34',N'Sơ lược về Laze','bai34lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 35',N'Tính chất và cấu tạo hạt nhân','bai35lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 36',N'Năng lượng liên kết của hạt nhân. Phản ứng hạt nhân ','bai36lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 37',N'Phóng xạ','bai37lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 38',N'Phản ứng phân hạch','bai38lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 39',N'Phản ứng nhiệt hạch','bai39lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 40',N'Các hạt sơ cấp','bai40lop12.html')
INSERT INTO  TWENTH VALUES (N'Bài 41',N'Cấu tạo vũ trụ','bai41lop12.html')

SELECT  * FROM TWENTH

DROP TABLE TENBASE
GO
DROP TABLE ELEVEN
GO
INSERT INTO TENBASE VALUES(N'Bài 1',N'Chuyển động cơ','bai1lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 2',N'Chuyển động thẳng đều','bai2lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 3',N'Chuyển động thẳng biến đổi đều','bai3lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 4',N'Sự rơi tự do','bai4lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 5',N'Chuyển động tròn đều','bai5lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 6',N'Tính tương đối của chuyển động','bai6lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 7',N'Sai số của phép đo các đại lượng vật lý','bai7lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 8',N'Thực hành: Khảo sát chuyển động rơi tự do - Xác định gia tốc rơi tự do','bai8lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 9',N'Tổng hợp và phân tích lực. Điều kiện cân bằng của chất điểm','bai9lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 10',N'Ba định luật Niu-tơn','bai10lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 11',N'Lực hấp dẫn. Định luật vạn vật hấp dẫn','bai11lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 12',N'Lực đàn hồi của lò xo. Định luật Húc','bai12lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 13',N'Lực ma sát','bai13lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 14',N'Lực hướng tâm','bai14lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 15',N'Bài toán về chuyển động ném ngang','bai15lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 16',N'Thực hành: Đo hệ số ma sát','bai16lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 17',N'Cân bằng của một vật chịu tác dụng của hai lực và của ba lực không song song','bai17lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 18',N'Cân bằng của một vật có trục quay cố định. Momen lực','bai18lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 19',N'Quy tắc hợp lực song song cùng chiều','bai19lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 20',N'Các dạng cân bằng. Cân bằng của một vật có mặt chân đế','bai20lop11.html')
GO
INSERT INTO TENBASE VALUES(N'Bài 21',N'Chuyển động tịnh tiến của vật rắn. Chuyển động quay của vật rắn quanh một trục cố định','bai21lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 22',N'Ngẫu lựu','bai22lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 23',N'Động lượng. Định luật bảo toàn động lượng','bai23lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 24',N'Công và Công suất','bai24lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 25',N'Động năng','bai25lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 26',N'Thế năng','bai26lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 27',N'Cơ năng','bai27lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 28',N'Cấu tạo chất','bai28lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 29',N'Quá trình đẳng nhiệt. Định luật Bôi-lơ - Ma-ri-ốt','bai29lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 30',N'Quá trình đẳng tích. Định luật Sác-lơ','bai30lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 31',N'Phương trình trạng thái của khí lí tưởng','bai31lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 32',N'Nội năng và sự biến thiên nội năng','bai32lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 33',N'Các nguyên lí của nhiệt động lực học','bai33lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 34',N'Chất rắn kết tinh. Chất rắn vô định hình','bai34lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 35',N'Biến dạng cơ của vật rắn','bai35lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 36',N'Sự nở vì nhiệt của vật rắn','bai36lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 37',N'Các hiện tượng bề mặt của chất lỏng','bai37lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 38',N'Sự chuyển thể của các chất','bai38lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 39',N'Độ ẩm không khí','bai39lop11.html')
INSERT INTO TENBASE VALUES(N'Bài 40',N'Thực hành: Đo hệ số căng bề mặt của chất lỏng','bai40lop11.html')
GO
SELECT *FROM TENBASE

INSERT INTO ELEVEN VALUES(N'Bài 1',N'Điện tích. Định luật Cu-lông','bai1lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 2',N'Thuyết Electron. Định luật bảo toàn điện tích','bai2lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 3',N'Điện trường và cường độ điện trường. Đường sức điện','bai3lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 4',N'Công của lực điện','bai4lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 5',N'Điện thế. Hiệu điện thế','bai5lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 6',N'Tụ điện','bai6lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 7',N'Dòng điện không đổi. Nguồn điện','bai7lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 8',N'Điện năng. Công suất điện','bai8lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 9',N'Định luật Ôm đối với toàn mạch','bai9lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 10',N'Ghép các nguồn điện thành bộ','bai10lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 11',N'Phương pháp giải một số bài toán về toàn mạch','bai11lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 12',N'Thực hành: Xác định suất điện động và điện trở trong của một pin điện hóa','bai12lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 13',N'Dòng điện trong kim loại','bai13lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 14',N'Dòng điện trong chất điện phân','bai14lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 15',N'Dòng điện trong chất khí','bai15lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 16',N'Dòng điện trong chân không','bai16lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 17',N'Dòng điện trong chất bán dẫn','bai17lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 18',N'Thực hành: Khảo sát đặc tính chỉnh lưu của điôt bán dẫn và đặc tính khuếch đại của tranzito','bai18lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 19',N'Từ trường','bai19lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 20',N'Lực từ. Cảm ứng từ','bai20lop11.html')
GO
INSERT INTO ELEVEN VALUES(N'Bài 21',N'Từ trường của dòng điện chạy trong các dây dẫn có hình dạng đặc biệt','bai21lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 22',N'Lực Lo-ren-xơ','bai22lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 23',N'Từ thông. Cảm ứng điện từ','bai23lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 24',N'Suất điện động cảm ứng','bai24lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 25',N'Tự cảm','bai25lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 26',N'Khúc xạ ánh sáng','bai26lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 27',N'Phản xạ toàn phần','bai27lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 28',N'Lăng kính','bai28lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 29',N'Thấu kính mỏng','bai29lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 30',N'Giải bài toán về hệ thấu kính','bai30lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 31',N'Mắt','bai31lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 32',N'Kính lúp','bai32lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 33',N'Kính hiển vi','bai33lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 34',N'Kính thiên văn','bai34lop11.html')
INSERT INTO ELEVEN VALUES(N'Bài 35',N'Thực hành: Xác định tiêu cự của thấu kính phân kì','bai35lop11.html')
GO
SELECT * FROM ELEVEN

CREATE TABLE DERAL10(
QID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CONTENT NVARCHAR(200) NOT NULL,
CTLDUNG NVARCHAR(200) NOT NULL,
CTL1 NVARCHAR(200),
CTL2 NVARCHAR(200),
CTL3 NVARCHAR(200)
)
GO
CREATE TABLE DERAL11(
QID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CONTENT NVARCHAR(200) NOT NULL,
CTLDUNG NVARCHAR(200) NOT NULL,
CTL1 NVARCHAR(200),
CTL2 NVARCHAR(200),
CTL3 NVARCHAR(200)
)
GO
CREATE TABLE DERAL12(
QID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
CONTENT NVARCHAR(200) NOT NULL,
CTLDUNG NVARCHAR(200) NOT NULL,
CTL1 NVARCHAR(200),
CTL2 NVARCHAR(200),
CTL3 NVARCHAR(200)
)

GO
INSERT INTO DERAL12 VALUES(
N'Chọn câu sai? Tần số dao động tuần hoàn là:',N'Số dao động thực hiện được trong 1 phút,',
N'Số chu kì thực hiện được trong một giây',N'Số lần trạng thái dao động lặp lại trong 1 đơn vị thời gian',N'Số lần li độ dao động lặp lại như cũ trong 1 đơn vị thời gian'
)
INSERT INTO DERAL12 VALUES (
N'Đại lượng nào sau đây không cho biết dao động điều hòa là nhanh hay chậm',
N'Biên độ',
N'Chu kì',
N'Tần số',
N'Tốc độ góc'
)
INSERT INTO DERAL12 VALUES (
N'Một chất điểm thực hiện dao động điều hòa với chu kì T = 3,14s và biên độ A = 1m. Tại thời điểm chất điểm đi qua vị trí cân bằng thì vận tốc của nó có độ lớn bằng: ',
N'2 m/s',
N'0,5 m/s',
N'1 m/s',
N'3 m/s'
)
INSERT INTO DERAL12 VALUES
(
N':Một vật dao động điều hoà khi vật có li độ x1 = 3cm thì vận tốc của nó là v1 = 40cm/s, khi vật qua vị trí cân bằng vật có vận tốc v2 = 50cm. Li độ của vật khi có vận tốc v3 = 30 cm/s là: ',
N'+_4 cm',
N'4 cm',
N'16 cm',
N'2 cm'
)
INSERT INTO DERAL12 VALUES
(
N'Phương trình dao động của một vật dao động điều hoà có dạng x = 6cos(10t +)(cm). Li độ của vật khi pha dao động bằng (-600) là: ',
N'3 cm',
N'-3 cm',
N'4,24 cm',
N'-4,24 cm'
)
INSERT INTO DERAL12 VALUES
(
N'Một vật dao động điều hoà, trong thời gian 1 phút vật thực hiện được 30 dao động. Chu kì dao động của vật là:',
N'2s',
N'30s',
N'0,5s',
N'1s'
)
INSERT INTO DERAL12 VALUES
(
N' Một vật dao động điều hoà có phương trình dao động là x = 5cos(2t +/3)(cm). Vận tốc của vật khi có li độ x = 3cm là ',
N'+_25,12cm/s',
N'25,12cm/s',
N'+_12,56cm/s',
N'12,56cm/s'
)
INSERT INTO DERAL12 VALUES
(
N' Một vật dao động điều hoà có phương trình dao động là x = 5cos(2t +/3)(cm). Lấy 2  = 10. Gia tốc của vật khi có li độ x=3cm là ',
N'-120 cm/s2',
N'-12 cm/s2',
N'1,20 m/s2',
N'-60 cm/s2'
)
INSERT INTO DERAL12 VALUES
(
N'Một vật dao động điều hòa dọc theo trục Ox. Vận tốc của vật khi qua vị trí cân bằng là 62,8cm/s và gia tốc ở vị trí biên là 2m/s2. Lấy 2  = 10.Biên độ và chu kì dao động của vật lần lượt là:',
N'20 cm; 2s',
N'10 cm; 1s',
N'1cm ; 0,1s',
N'2cm ; 0,2s'
)
INSERT INTO DERAL12 VALUES
(
N'Một chất điểm M chuyển động đều trên một đường tròn với tốc độ dài 160cm/s và tốc độ góc 4 rad/s. Hình chiếu P của chất điểm M trên một đường thẳng cố định nằm trong mặt phẳng hình tròn dao động điều hoà với biên độ và chu kì lần lượt là: ',
N'40cm - 1,57s',
N'40cm - 0,25s',
N'40 m - 0,25s',
N'2,5m - 1,57s'
)
INSERT INTO DERAL12 VALUES
(
N'Phương trình vận tốc của một vật dao động điều hoà là v = 120cos20t(cm/s), với t đo bằng giây. Vào thời điểm t = T/6(T là chu kì dao động), vật có li độ là:',
N' 3 căn 3 cm',
N'-3cm',
N'-3 căn 3 cm',
N'3cm'
)
INSERT INTO DERAL12 VALUES
(
N'Chọn kết luận đúng khi nói về dao động điều hoà cuả con lắc lò xo:',
N'Quỹ đạo là một đoạn thẳng',
N'Vận tốc tỉ lệ thuận với thời gian.',
N'Gia tốc tỉ lệ thuận với thời gian.',
N'Quỹ đạo là một đường hình sin'
)
INSERT INTO DERAL12 VALUES
(
N' Đối với dao động tuần hoàn, khoảng thời gian ngắn nhất mà sau đó trạng thái dao động của vật được lặp lại như cũ được gọi là: ',
N'chu kì dao động.',
N'tần số dao động',
N'chu kì riêng của dao động',
N'tần số riêng của dao động.'
)
GO
SELECT * FROM DERAL10
SELECT * FROM DERAL11
SELECT * FROM DERAL12

DROP TABLE DERAL12
INSERT INTO DERAL10 VALUES 
(
	N'Hãy chọn câu đúng:',
	N'Hệ quy chiếu bao gồm vật làm mốc, hệ toạ độ, mốc thời gian và đồng hồ',
	N'Hệ quy chiếu bao gồm vật làm mốc, hệ toạ độ, mốc thời gian',
	N'Hệ quy chiếu bao gồm hệ toạ độ, mốc thời gian và đồng hồ',
	N'Hệ quy chiếu bao gồm vật làm mốc, mốc thời gian và đồng hồ'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Một vật chuyển động dọc theo chiều (+) trục Ox với vận tốc không đổi, thì',
	N'vận tốc của vật luôn có giá tri (+)',
	N'tọa độ của vật luôn có giá trị (+)',
	N'tọa độ và vận tốc của vật luôn có giá trị (+)',
	N'tọa độ luôn trùng với quãng đường'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Từ A một chiếc xe chuyển động thẳng trên một quãng đường dài 10 km, rồi sau đó lập tức quay về về A. Thời gian của hành trình là 20 phút. Tốc độ trung bình của xe trong thời gian này là:',
	N'60 km/h',
	N'20 km/h',
	N'30 km/h',
	N'40 km/h'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Một chiếc xe chạy trên đoạn đường 40 km với tốc độ trung bình là 80 km/h, trên đoạn đường 40 km tiếp theo với tốc độ trung bình là 40 km/h. Tốc độ trung bình của xe trên đoạn đường 80 km này là:',
	N'53 km/h',
	N'65 km/h',
	N'60 km/h',
	N'50 km/h'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Câu nào sau đây nói về sự rơi là đúng?',
	N'Ở cùng một nơi, mọi vật rơi tự do có cùng gia tốc',
	N'Khi không có sức cản, vật nặng rơi nhanh hơn vật nhẹ',
	N'Khi rơi tự do, vật nào ở đọ cao hơn sẽ rơi với gia tốc lớn hơn',
	N' Vận tốc của vật chạm đất, không phụ thuộc vào độ cao của vật khi rơi'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Một vật rơi thẳng đứng từ độ cao 19,6 m với vận tốc ban đầu bang 0 (bỏ qua sức cản không khí, lấy g = 9,8 m/s2). Thời gian vật đi được 1 m cuối cùng bằng',
	N'0,05 s',
	N'0,45 s',
	N'1,95 s',
	N'2 s'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Một người chạy thể dục buổi sáng, trong 10 phút đầu chạy được 3,0 km; dừng lại nghỉ trong 5 phút, sau đó chạy tiếp 1500 m còn lại trong 5 phút. Tốc độ trung bình của người đó trong cả quãng đường là',
	N'225 mét/phút',
	N'300 mét/phút',
	N'75 mét/phút',
	N'200 mét/phút'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Hai ô tô cùng khởi hành từ hai địa điểm A và B cách nhau 100 km, chuyển động cùng chiều, ô tô A có vận tốc 60 km/h, ô tô B có vận tốc 40 km/h. Chọn trục tọa độ là đường thẳng AB, gốc tọa độ tại A, chiều dương từ A đến B. Hai xe gặp nhau cách B bao nhieu km?',
	N'200 km',
	N'60 km',
	N'100 km',
	N'300 km'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Trong giới hạn đàn hồi, độ lớn lực đàn hồi của lò xo không phụ thuộc vào yếu tố nào sau đây?',
	N'Khối lượng của lò xo',
	N'Độ biến dạng của lò xo',
	N'Bản chất của chất làm lò xo',
	N'Chiều dài của lò xo'
)
go
INSERT INTO DERAL10 VALUES 
(
	N'Một xe ô tô có khối lượng 1,2 tấn, chuyển động chậm dần đều cho đến khi dừng lại thì đi được quãng đường 96 m. Biết quãng đường xe đi được trong giây đầu tiên gấp 15 lần quãng đường xe đi được trong giây cuối. Độ lớn của hợp lực tác dụng vào xe trong quá trình chuyển động chậm dần đều là',
	N'3600 N',
	N'2500 N',
	N'1800 N',
	N'2900 N'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Một điện tích điểm q đặt tại điểm O. Hai điểm M,N nằm cùng một đường sức điện (theo thứ tự O,M,N) có ON=3MN. Vecto cường độ điện trường tại M và N có:',
	N'cùng phương,cùng chiều,độ lớn EN=3EM',
	N'cùng phương, cùng chiều,độ lớn EM=3EN',
	N'cùng phương,ngược chiều, độ lớn EM=3EN',
	N'cùng phương,cùng chiều,độ lớn EM=2,25EN'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Dưới tác dụng của lực điện trường, điện tích q > 0 di chuyển được một đoạn đường thẳng s trong điện trường đều,theo phương hợp với vecto cường độ điện trường E→một góc α. Trường hợp nào sau đây, công của lực điện trường là lớn nhất?',
	N'α=0',
	N'α=45o',
	N'α=60o',
	N'α=90o'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Cho biết nikem có khối lượng mol nguyên tử là 58,7 và hoá trị . Nếu cho dòng điện không đổi có cường độ 5A chạy qua một bình điện phân chứa dung dịch muối niken trong khoảng thời gian 1 giờ thì khối lượng niken giải phóng ra ở catot của bình điện phân là',
	N'5,47g',
	N'2,73g',
	N'547g',
	N'273g'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Trong sự điện phân dung dịch CuSO4 người ta thu được 500g đồng. Hiệu điện thế đặt vào hai điện cực là 24V. Biết hiệu suất của bình điện phân là 80%, khối lượng mol nguyên tử của đồng là 64 và hoá trị 2. Điện năng cần thiết cho quá trình điện phân là',
	N'12,5 kW.h',
	N'8 kW.h',
	N'1,25 kW.h',
	N'8 kW.h'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Một ống dây hình trụ, tiết diện đều, không có lõi thép. Số vòng dây trên mỗi mét chiều dài ống là 5000 vòng. Mắc ống dây vào một nguồn có suất điện động bằng 12V, điện trở trong không đáng kể. Biết điện trở của ống dây là R=0,5Ω	. Cảm ứng từ trong long của ống dây có độ lớn gần đúng bằng',
	N'0,15T',
	N'0,18T',
	N'0,2T',
	N'0,25T'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Kí hiệu nào dưới đây có thể coi là kí hiệu ứng với đơn vị từ thông?',
	N'A.H',
	N'Tm',
	N'H/A',
	N'A/H'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Từ thông qua diện tích S đặt trong từ trường đều là dương khi góc hợp bởi đường sức từ và pháp tuyến đối với S',
	N'là góc nhọn',
	N'là góc tù',
	N'bằng π ',
	N'bằng π/2'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Một tia sáng đi từ nước đến mặt phân cách với không khí có góc tới i. Biết chiết suất của nước là 4/3. Tia sáng tới mặt phân cách này thì xảy ra phản xạ toàn phần. Góc tới I có giá trị gần nhất với giá trị nào sau đây?',
	N'50o',
	N'40o',
	N'30o',
	N'45o'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Một chiếc thước dài 1m được đánh dấu 100 vạch, hai vạch lien tiếp cách nhau 1cm. Quan sát thước theo phương gần như vuông góc với mặt nước thì thấy ảnh của vạch 84 ngoài không khí trùng với vạch số 0 trong nước. Biết chiết suất của nước là 4/3. Độ sâu của nước trong bể là',
	N'48cm',
	N'54cm',
	N'42cm',
	N'36cm'
)
go
INSERT INTO DERAL11 VALUES 
(
	N'Một bể chứa nước có thành cao 80cm, đáy phẳng dài 120mm. Độ cao mực nước trong bể là 60cm và có chiết suất là 4/3. Ánh nắng chiếu theo phương nghiêng 30o so với mặt nước trong bể. Độ dài bóng đen tạo thành ở trên mặt nước và trên đáy bể là',
	N'34,6cm và 86,2cm',
	N'11,5cm và 63,7cm',
	N'34,6cm và 51,6cm',
	N'34,6cm và 44,4cm'
)






