# Simple-Accountbook ( an account book written by C sharp )
## Download:
Click below !<br>
https://github.com/chs415009/simple-accountbook.git


## Instructions:
__This project allows you to record all your expense and income with several functions.__ <br>
~ The detailed procedure is shown below. ~
### Form 1
* __The first form is for sign in/ sign up.__
<img src="./bin/1.png" width="500">

* The initial input of the username and password serves as the registration process. The system will check if this account exists.<br>
If it doesn't, a prompt will appear asking whether to proceed with registration. <br>
<br>
<br> 
<div style="display: flex;">
  <img src="./bin/1 no account.png" width="100">
  <img src="./bin/1 no password.png" width="100">
  <img src="./bin/1 no account password .png" width="100">
  <img src="./bin/1 X password.png" width="100">
</div>
<br> 

* As for the four above images, the system will automatically if there are blanks or incorrect password. 

### Form 2
* __The second form is the main page.<br>__
From left to right, the three buttons are: 離開-Exit, 新增-Add, 檢視-View. 
<img src="./bin/2.png" width="500">
<br>

* The "離開" button is for save and exit. When you click it, it will confirm agian. <br> 
* The "新增" and "檢視" buttons will take you to "Form3" and "Form4" respectively. <br>
(Form3 and Form4 are explained below) 
<img src="./bin/2 save.png" width="500">
<br>

* If click true, it will successfully save and quit. <br>
* If click false, it won't save and quit. Instead, it will show the changes from the previous login to now.
(pic)
<br>

### Form 3
* __The third form is for adding new records.<br>__
<br>
1. <img src="./bin/3.png" width="500">

* First, you can select the date at the top of the page.<br>
** _You will need to select from year to day squentially to correctly show 29th, 30th, 31th. <br>
Otherwise, it may have errors on the date_. **

<br>
2. <img src="./bin/3 add.png" width="500">

* After you successfully add a new record, the message box will show the result.

<br>
3. <img src="./bin/3 add list.png" width="500">

* As follows, the second message box will appear after the first one. <br>
It shows all the records added that happened before leaving Form3.

<br>
4. <img src="./bin/3 X money.png" width="500">

* As to the above image, if the category of the record is belong to "income" and the money is negative, <br>
it will show "金額輸入錯誤", which means wrong format for the money.
* However, if you input positive number while selecting categories beloning to "expense", it will atoumatically add "-".
























