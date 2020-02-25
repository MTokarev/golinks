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


## Installation
* Linux x64 (Tested on Centos and RHEL 7,8)

`SELinux must be configured in order to run this app`

If you want to do a POC for this product you can temporary disable SELinux by running
```
setenforce 0
```
Then you can run these commands:


```
# For CentOS,RHEL 7

wget https://github.com/MTokarev/golinks/blob/master/bin/Debug/netcoreapp2.2/linux-x64/linux-x64.tar.gz?raw=true -O /tmp/linux-x64.tar.gz
mkdir -p /var/www/golink
tar -xvf /tmp/linux-x64.tar.gz -C /var/www/golink
mv /var/www/golink/golink.service /etc/systemd/system
chmod +x /var/www/golink/golink
systemctl enable golink
systemctl start golink
firewall-cmd --permanent --zone=public --add-service=http
firewall-cmd --reload
```
By default the app will bind to the 0.0.0.0:80 which can be ovverided by setting --urls in `/etc/systemd/system/golink.service`




Please don't blame me to much, since it is my first project using .net