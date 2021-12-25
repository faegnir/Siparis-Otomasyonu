# Siparis-Otomasyonu

Both #TR and #EN explanation below..

Note: If -- Application.StartupPath + "\\Items\\items.txt" or Application.StartupPath + "\\Items\\orders.txt"-- causes a problem 
you just have to add "Items" Folder(contains 2 .txt files) to the application start up path as demonstrated above 
and inside the folder you have to add 2 .txt files "orders" and "items". 
Also reminder that login menu based on a local sql database.


Admin Girişi bilgileri -- Username: admin -- Password: 1234


#TR

Ödevin Amacı

Ödevin amacı küçük işletmelerin kullanabileceği, ürünlerini ve müşterilerini hızlı ve kolay bir biçimde idare edebilecekleri uygulamayı hayata geçirebilmek. 
Bu ödev kapsamında kullanılan teknolojiler: Visual Studio IDE, GitHub, C# programlama dili ve SQL.

Programın Kullanımı

Programın kullanımı oldukça basittir. Açılış menüsü iki kısımdan oluşuyor. 
Asıl kısım giriş ekranıdır. Diğer kısmı ise Kayıt Ekranıdır. 
Kayıt ekranı ve giriş ekranı SQL Veritabanı kullanılarak yapılmıştır. 

Eğer giriş ekranına admin bilgileri1 kullanılarak girilirse Admin Kontrol Paneli açılır. 

Admin Kontrol Panelinin bir diğer menüsü ise Ürün Ekleme Menüsüdür. 
Eklenen yeni ürün, Müşteri Menüsünde daha önce eklenmiş ürünlerin altında görünür. 

Eğer giriş ekranına Kayıt Ekranında girilen bilgiler girilirse Müşteri Menüsü açılır.
Müşteri Menüsünde sol taraftaki kutucukta daha önceden Admin tarafından eklenmiş ürünler görünür ve müşteri buradan sepetine eklemek istediği ürünü seçebilir.
Ürünler sepete eklendikten sonra Ödeme butonuna basılarak Ödeme Menüsüne geçilir. 

İki tip ödeme yöntemi vardır. 
Kredi Kartı ile Ödeme kredi kartı bilgilerinin doldurulmasını istemektedir. Nakit Ödeme kapıda ödemedir.

#EN

Technologies that have been used in this app: C#, SQL Database, Visual Studio 2019, Git.

How to use..

This Order Managment app is pretty simple to use. First screen you will see when you open the app will be Login Menu.
If you sign in with administrator login infos, program will direct you to the Admin Menu.
Admin Menu has 2 features.
First, you can track and see the customers and what did they buy.
Second, you can add items, their weight and their price to the app, which will eventually can seen and be bought by customers.

If you sign up as a customer and sign in with that info, program will direct you to the Main Menu.
On the Main Menu there is a List Box on the left side which contains the goods you just put on Admin menu and shopping cart box on the right side of it.
If there are any items in the List Box you should see them in 'Name - Price - Weight' format.
You can buy goods by clicking on them once and specifying the quantity for it. 
After that you have to click "save order button" to put those items to Shopping Cart.
This action will automatically calculate the sub-total price, taxes, total weight and the total price of the goods that are in the shopping cart.
There is an option for resetting the cart as well.
At last, there is a "Payment" button which will lead you to the Payment Menu in case you click on it.

Payment Menu has 2 options. Payment with credit card and cash on delivery option.
Credit button will lead you to the another window which gets (!) your card infos and returns a message that indicates the process was successful.
Cash on delivery button gives the same message except this option doesn't require any payment information as expected.



