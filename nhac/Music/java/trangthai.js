var speed = 50 
var pause = 2500 
var timerID = null
var bannerRunning = false
var ar = new Array()
ar[0] = "º°¨(¯`•.¸(¯`•.¸Chào mừng bạn đến với website http://dulichcaobang.Net.!¸.•´¯)¸.•´¯)¨°º"
ar[1] = "º°¨(¯`•.¸(¯`•.¸Chúc các bạn có những giây phút thư giãn thoải mãi trên website này¸.•´¯)¸.•´¯)¨°º"
ar[2] = "º°¨(¯`•.¸Designed By Admin: Anh lực . Yahoo: hoanghonthucgiac_03 .•´¯)¨°º"
ar[3] = "*********º°¨(¯`•.¸Contact: email: luc4188@gmail.com¸.•´¯)¨°º************"
ar[4] = "Cuộc đời anh là một cơn mộng kéo dài.Nó trôi qua thật êm đềm và tĩnh lặng...!Anh chìm đắm trong cơn mơ đó..."
ar[5] = "Tưởng chừng như không bao giờ tỉnh giấc....Và để rồi vào một ngày đẹp trời...?Anh đã choàng tỉnh cơn mộng đó...!!!"
ar[6] = "Vì đã có một người con gái đến đánh thức con tim tình yêu đang ngủ say của Anh dzzậyzzz...."
ar[7] = "º°¨(¯`•.¸(¯`•.¸Người con gái ấy chính là ....!¸.•´¯)¸.•´¯)¨°º"
ar[8] = "Mơ có thể tỉnh giấc...Hoa có thể lìa cành....Đúng....! Nhưng tình bạn chân thành không bao giờ thay đổi..."
ar[9] = "Một cơn gió nhẹ khẽ lướt qua làm ta se lạnh...Em cũng như cơn gió nhẹ nhàng thoáng qua...¸.•´¯)¨°º"
ar[10] = "º°¨(¯`•.¸(¯`•.¸Để lại trong ta một nỗi buồn...man mác...vô cùng....!!!¸.•´¯)¸.•´¯)¨°º"
ar[11] = "º°¨(¯`•.¸Điều đáng sợ nhất trong cuộc sống không phải là cái chết...mà là sự lãng quên...Là khi..¸.•´¯)¨°º"
ar[12] = "Người bạn yêu thương nhất...!!! Từ bỏ tấm chân tình của bạn...Để chạy theo những điều hư ảo..¸.•´¯)¨°º"
ar[13] = "Là khi những người bạn thân của bạn từ bỏ bạn... Vì đơn giản rằng họ không hiểu bạn...Không thông cảm với bạn...."
ar[14] = "...:::º°¨(¯`•.¸(¯`•.¸(¯`•.¸(¯`•.¸(¯`•.¸Dễ và Khó¸.•´¯)¸.•´¯)¸.•´¯)¸.•´¯)¸.•´¯)¨°º:::..."
ar[15] = "º°¨(¯`•.¸Dễ là khi để xảy ra sai lầm, nhưng khó là khi học từ những sai lầm đó.¸.•´¯)¨°º"
ar[16] = "Dễ là khi buồn bực vì một điều gì đó mất đi, nhưng khó là khi quan tâm đủ đến điều đó để đừng làm mất."
ar[17] = "º°¨(¯`•.¸Dễ là khi nghĩ về một việc, nhưng khó là khi ngừng suy nghĩ và bắt đầu hành động.¸.•´¯)¨°º"
ar[18] = "º°¨(¯`•.¸Dễ là khi nghĩ xấu về người khác, nhưng khó là khi cho họ niềm tin.¸.•´¯)¨°º"
ar[19] = "Dễ là khi bạn có một chỗ trong sổ địa chỉ của một người, nhưng khó là khi bạn tìm được một chỗ trong trái tim của người đó."
ar[20] = "º°¨(¯`•.¸Dễ là khi đánh giá lỗi lầm của người khác, nhưng khó là khi nhận ra sai lầm của chính mình."
ar[21] = "º°¨(¯`•.¸Dễ là khi nói mà không suy nghĩ, nhưng khó là khi biết kiểm soát những lời nói của mình.¸.•´¯)¨°º"
ar[22] = "º°¨(¯`•.¸Dễ là khi làm tổn thương một người mà bạn yêu thương, nhưng khó là khi hàn gắn vết thương đó.¸.•´¯)¨°º"
ar[23] = "º°¨(¯`•.¸Dễ là khi tha thứ cho người khác, nhưng khó là khi làm cho người khác tha thứ cho mình¸.•´¯)¨°º"
ar[24] = "º°¨(¯`•.¸Dễ là khi đặt ra các nguyên tắc, nhưng khó là khi làm theo chúng.¸.•´¯)¨°º"
ar[25] = "º°¨(¯`•.¸Dễ là khi nằm mơ hàng đêm, nhưng khó là khi chiến đấu vì một ước mơ.¸.•´¯)¨°º"
ar[26] = "º°¨(¯`•.¸Dễ là khi thể hiện chiến thắng, nhưng khó là khi nhìn nhận một thất bại.¸.•´¯)¨°º"
ar[27] = "º°¨(¯`•.¸Dễ là khi vấp phải một hòn đá và ngã, nhưng khó là khi đứng dậy và đi tiếp.¸.•´¯)¨°º"
ar[28] = "º°¨(¯`•.¸Dễ là khi hứa một điều với ai đó, nhưng khó là khi hoàn thành lời hứa đó.¸.•´¯)¨°º"
ar[29] = "Dễ là khi chúng ta nói rằng chúng ta yêu thương, nhưng khó là khi làm cho người khác cảm thấy như thế hàng ngày."
ar[30] = "º°¨(¯`•.¸Dễ là khi phê bình người khác, nhưng khó là khi cải thiện chính bản thân mình.¸.•´¯)¨°º"
ar[31] = "º°¨(¯`•.¸Dễ là khi nhận, nhưng khó là khi cho.Dễ là khi đọc những điều này, nhưng khó là khi bạn thực hiện nó."
ar[32] = "º°¨(¯`•.¸(¯`•.¸Nếu cơ hội mãi không gõ cửa, bạn phải xem mình đã xây một cánh cửa chưa đã...¸.•´¯)¸.•´¯)¨°º"
var currentMessage = 0
var offset = 0
function stopBanner() {
if (bannerRunning)
clearTimeout(timerID)
bannerRunning = false
}
function startBanner() {
stopBanner()
showBanner()
}
function showBanner() {
var text = ar[currentMessage]
if (offset < text.length) {
if (text.charAt(offset) == " ")
offset++ 
var partialMessage = text.substring(0, offset + 1) 
window.status = partialMessage
offset++ 
timerID = setTimeout("showBanner()", speed)
bannerRunning = true
} else {
offset = 0
currentMessage++
if (currentMessage == ar.length)
currentMessage = 0
timerID = setTimeout("showBanner()", pause)
bannerRunning = true
}
}
startBanner();

///
<!-- Begin
function mora(website) {
var windowprops='width=50,height=50,scrollbars=yes,status=yes,resizable=yes'
var heightspeed = 35;
var widthspeed = 50; 
var leftdist = 50;  
var topdist = 50;    
if (window.resizeTo&&navigator.userAgent.indexOf("Opera")==-1) {
var winwidth = window.screen.availWidth - leftdist;
var winheight = window.screen.availHeight - topdist;
var sizer = window.open("","","left=" + leftdist + ",top=" + topdist +","+ windowprops);
for (sizeheight = 1; sizeheight < winheight; sizeheight += heightspeed)
sizer.resizeTo("1", sizeheight);
for (sizewidth = 1; sizewidth < winwidth; sizewidth += widthspeed)
sizer.resizeTo(sizewidth, sizeheight);
sizer.location = website;
}
else
window.open(website,'mywindow');
}
