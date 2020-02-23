# GoLinks WebApp

Using this site you can simplify mapping of compllex URLs to the meaningful alias.
Let's say that your user need to access mail and the URL is  https://office.outlook365.com/owa in this case you can register an alias like go/mail or https://go.domain.com/mail.

This project is built using asp.net core and can be packaged to run both on win32 or linux OS.

I have added an API controller [SiteController] in order to work in programatically way just in case you want to integrate something to it.

App functionality:
---
* Creatining mapping
* Removing Mapping
* Search for aliases
* Logging how many times site was accessed
* Board on the home page with most visited sites
* API to work with site programmatically
  
Small demo:
---
![img](~/../Docs/Img/goLinksDemo.gif)

Please don't blame me to much, since it is my first project using .net