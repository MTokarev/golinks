# GoLinks WebApp

## Content:

* [Overview](#Overview)

* [Feautures](#App-features)
* [Demo](#Small-demo)
* [Installation on Linux](#Linux-x64)
* Installation on Windows
* [Installation Demo](#Installation-Demo)
* Known issues
* ToDo

### Overview

Using this site you can simplify mapping of compllex URLs to the meaningful alias.
Let's say that your user need to access mail and the URL is  https://office.outlook365.com/owa in this case you can register an alias like go/mail or https://go.domain.com/mail.

This project is built using asp.net core and can be packaged to run both on win32 or linux OS.

I have added an API controller [SiteController] in order to work in programatically way just in case you want to integrate something to it.

### App features:

* Creatining mapping
* Removing Mapping
* Search for aliases
* Logging how many times site was accessed
* Board on the home page with most visited sites
* API to work with site programmatically
  
Small demo:
---
![img](~/../Docs/Img/goLinksDemo.gif)


# Installation

## Linux x64 
### (Tested on Centos and RHEL 7,8)

`NOTE: SELinux must be configured in order to run this app`

If you want to do a POC for this product you can temporary disable SELinux by running
```
setenforce 0
```
Then you can run these commands:

`[CENTOS7|RHEL7]`

```
wget https://github.com/MTokarev/golinks/blob/master/bin/Debug/netcoreapp2.2/linux-x64/linux-x64.tar.gz?raw=true -O /tmp/linux-x64.tar.gz
mkdir -p /var/www/golink
tar -xvf /tmp/linux-x64.tar.gz -C /var/www/golink
```
`[CENTOS8|RHEL8]`

```
wget https://github.com/MTokarev/golinks/blob/master/bin/Debug/netcoreapp2.2/linux-x64-rhel8/linux-x64-rhel8.tar.gz?raw=true -O /tmp/linux-x64-rhel8.tar.gz
mkdir -p /var/www/golink
tar -xvf /tmp/linux-x64-rhel8.tar.gz -C /var/www/golink
```

`For both 7 and 8`

```
mv /var/www/golink/golink.service /etc/systemd/system
chmod +x /var/www/golink/golink
systemctl enable golink
systemctl start golink
firewall-cmd --permanent --zone=public --add-service=http
firewall-cmd --reload
```


`NOW you can try to access your site by navigating http://yourhostname`

By default the app will bind to the 0.0.0.0:80 which can be ovverided by setting --urls in `/etc/systemd/system/golink.service`

From:

`ExecStart=/var/www/golink/golink --urls "http://0.0.0.0:80"`

To:

`ExecStart=/var/www/golink/golink --urls "http://0.0.0.0:8080"`

If you need to bind to the 8080 port.
This can be also helpful if you want to install your service to alternate port and put this app behind Apache or NGINX.

### Instalation Demo

`Installing golink on CentOS7`
![img](~/../Docs/Img/InstallationDemo.gif)


### Logging
You can check logs by running:

`journalctl -fu golink.service`



Please don't blame me to much, since it is my first project using .net