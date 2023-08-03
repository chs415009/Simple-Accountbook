# Simple-Accountbook 
Description :  The account book written in C sharp 
## Download:
1. Click below !<br>
https://github.com/chs415009/simple-accountbook.git <br>

2. Use Visual Studio to operate it by executing "AccoutingAPP.sln" file.<br>


## Instructions:
__This project allows you to record all your expense and income with several functions.__ <br>
~ The detailed procedure is shown below. ~ <br>
<br>

### --- Form 1 ----------
* __The first form is for sign in/ sign up.__

__1.__ <br>
<img src="./bin/1.png" width="500">

* The initial input of the username and password serves as the registration process. The system will check if this account exists.<br>
If it doesn't, a prompt will appear asking whether to proceed with registration.<br>
<br>

__2.__ <br>
<div style="display: flex;">
  <img src="./bin/1 no account.png" width="100">
  <img src="./bin/1 no password.png" width="100">
  <img src="./bin/1 no account password .png" width="100">
  <img src="./bin/1 X password.png" width="100">
</div>

* As for the four above images, the system will automatically if there are blanks or incorrect password. <br>
<br>

### --- Form 2 ----------
* __The second form is the main page.__ <br>
From left to right, the three buttons are: 離開-Exit, 新增-Add, 檢視-View.

__1.__ <br>
<img src="./bin/2.png" width="500">

* The "離開" button is for save and exit. When you click it, it will confirm agian. <br> 
* The "新增" and "檢視" buttons will take you to "Form3" and "Form4" respectively. <br>
(Form3 and Form4 are explained below)<br>
<br>

__2.__ <br>
<div style="display: flex;">
  <img src="./bin/2 save.png" width="500">
  <img src="./bin/2 X exit.png " width="500"> 
</div>

* If click true, it will successfully save and quit. <br>
* If click false, it won't save and quit. Instead, it will show all the records for you to check.<br>
<br>

### --- Form 3 ----------
* __The third form is for adding new records.__

__1.__ <br>
<img src="./bin/3.png" width="500">

* First, you can select the date at the top of the page.<br>
** _You will need to select from year to day squentially to correctly show 29th, 30th, 31th. <br>
Otherwise, it may have errors on the date_. **<br>
<br>

__2.__ <br>
<img src="./bin/3 add.png" width="500">

* After you successfully add a new record, the message box will show the result.<br>
<br>

__3.__ <br>
<img src="./bin/3 add list.png" width="500">

* As follows, the second message box will appear after the first one. <br>
It shows all the records added that happened before leaving Form3.<br>
<br>

__4.__ <br>
<img src="./bin/3 X money.png" width="500">

* As to the above image, if the category of the record is belong to "income" and the money is negative, <br>
  it will show "金額輸入有誤!", which means wrong format for the money.
* However, if you input positive number while selecting categories beloning to "expense", it will atoumatically add "-".<br>
<br>

### --- Form 4 ----------
* __The fourth form is for viewing and deleting records.__

__1.__ <br>
<img src="./bin/4.png" width="500">

* The list on the left side refers to all the records with information, including category, description, money and date.<br>
<br>

__2.__ <br>
<div style="display: flex;">
  <img src="./bin/4 find result.png" width="500">
  <img src="./bin/4 find list.png" width="100">
</div>
  
* The records on the right side can be filtered by the category you selected in "查詢" textbox. <br>
  "-" Represents the level of each group of categories <br>
  ( Ex: Selecting "交通" will show the results ,including "汽油", "公車", "火車", "捷運", "其他(交" )<br>
<br>

__3.__ <br>
<div style="display: flex;">
  <img src="./bin/4 delete.png" width="400">
  <img src="./bin/4 X delete.png" width="400">  
</div>

* If you want to delete a record, you will have to select it on the right side and then click "刪除" button. <br>
  ** _You can only delete one record at a time._ **
* If you click the button without selecting any records, it will notice you with a messgae box. <br>

## Let's begin !




























