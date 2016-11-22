<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="one_page_Default" %>

<%@ Register Src="~/UserControls/DefaultMenu.ascx" TagPrefix="Cwx121" TagName="DefaultMenu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8">
        <meta name="description" content="">
        <meta name="keywords" content="">
        <meta name="author" content="Pragmatic Mate s.r.o. - http://pragmaticmates.com">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="shortcut icon" href="#">
        <link rel="stylesheet" type="text/css" href="../assets/fonts/ed-fonts.css">
        <link rel="stylesheet" type="text/css" href="../assets/libraries/font-awesome/css/font-awesome.css" media="screen, projection">
        <link rel="stylesheet" type="text/css" href="../assets/libraries/rs-plugin/css/settings.css" media="screen, projection">
        <link rel="stylesheet" type="text/css" href="../assets/css/bootstrap.min.css" media="screen, projection">
        <link rel="stylesheet" type="text/css" href="../assets/css/animation.min.css" media="screen, projection">
        <link rel="stylesheet" type="text/css" href="../assets/css/heaven.css" media="screen, projection">
        <link href='../assets/css/fonts.googleapis.css' rel='stylesheet' type='text/css'>

        <title>گروه آموزشی طلوع </title>

    </head>
    <body class="sticky-header">
        <form id="form1" runat="server">

            <div id="wrapper">
                <header id="menu-home" class="block-content navbar-wrapper">

                    <div class="navbar-outer">

                        <div class="navbar-inner">
                            <nav class="navbar" role="navigation">

                                <div class="navbar-decoration">

                                    <div class="container">

                                        <div class="navbar-header">
                                            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-6">
                                                <span class="sr-only">Toggle navigation</span>
                                                <span class="icon-bar"></span>
                                                <span class="icon-bar"></span>
                                                <span class="icon-bar"></span>
                                            </button>
                                            <a class="navbar-brand" href="#">
                                                <img src="../assets/img/logo.png" alt="Home">
                                            </a>
                                        </div>

                                        <!-- /.navbar-header -->

                                        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-6">
                                            <Cwx121:DefaultMenu runat="server" ID="DefaultMenu" />
                                            <!-- /.nav-->
                                        </div>

                                        <!-- /.navbar-collapse -->
                                    </div>

                                    <!-- /.container -->
                                </div>

                                <!-- /.navbar-decoration -->
                            </nav>
                            <!-- /.navbar -->

                            <div class="container">

                                <div class="row">

                                    <div class="navbar-title-wrapper col-xs-12">

                                        <div class="tp-banner-container">

                                            <div class="tp-banner rs-banner">
                                                <ul class="unstyled" style="position: relative">
                                                    <!-- CHART -->
                                                    <li data-transition="fade" data-masterspeed="0" data-slotamount="6">
                                                        <img src="../assets/img/transparent.png" alt="">
                                                        <!-- CHART -->

                                                        <div class="tp-caption sfb"
                                                            data-x="230"
                                                            data-y="200"
                                                            data-speed="900"
                                                            data-width="872"
                                                            data-height="719">
                                                            <img src="../assets/img/tmp/slider/chart.png" alt="">
                                                        </div>

                                                        <!-- TITLE -->

                                                        <div class="tp-caption sft"
                                                            data-start="1500"
                                                            data-x="center"
                                                            data-y="20"
                                                            data-speed="900"
                                                            data-width="248"
                                                            data-height="209">

                                                            <div class="rs-title center">

                                                                <h2>ASP.NET Webform</h2>

                                                                <h3 class="mb30">آموزش برنامه نویسی و طراحی سایت</h3>

                                                                <a href="http://tolooco.ir" target="_blank" class="btn btn-simple">بیشتر بدانید
                                                                </a>
                                                            </div>

                                                            <!-- /.rs-title -->
                                                        </div>

                                                        <!-- CHART ORANGE -->

                                                        <div class="tp-caption sfl"
                                                            data-start="1500"
                                                            data-x="120"
                                                            data-y="320"
                                                            data-speed="900"
                                                            data-width="248"
                                                            data-height="209">
                                                            <img src="../assets/img/tmp/slider/chart-orange.png" alt="">
                                                        </div>

                                                        <!-- CHART RED -->

                                                        <div class="tp-caption sft"
                                                            data-start="1700"
                                                            data-x="110"
                                                            data-y="120"
                                                            data-speed="900"
                                                            data-width="320"
                                                            data-height="287">
                                                            <img src="../assets/img/tmp/slider/chart-red.png" alt="">
                                                        </div>

                                                        <!-- CHART GREEN -->

                                                        <div class="tp-caption sft"
                                                            data-start="1900"
                                                            data-x="650"
                                                            data-y="190"
                                                            data-speed="900"
                                                            data-width="378"
                                                            data-height="151">
                                                            <img src="../assets/img/tmp/slider/chart-green.png" alt="">
                                                        </div>

                                                        <!-- CHART BLUE -->

                                                        <div class="tp-caption sfr"
                                                            data-start="2100"
                                                            data-x="845"
                                                            data-y="295"
                                                            data-speed="900"
                                                            data-width="378"
                                                            data-height="151">
                                                            <img src="../assets/img/tmp/slider/chart-green.png" alt="">
                                                        </div>

                                                        <div class="tp-bannertimer tp-bottom"></div>

                                                    </li>
                                                    <!-- WOMAN -->
                                                    <li data-transition="fade" data-masterspeed="0" data-slotamount="6">
                                                        <img src="../assets/img/transparent.png" alt="">
                                                        <!-- WOMAN -->

                                                        <div class="tp-caption sfb"
                                                            data-x="100"
                                                            data-y="20"
                                                            data-speed="900"
                                                            data-width="969"
                                                            data-height="595">
                                                            <img src="../assets/img/tmp/slider/woman.png" alt="">
                                                        </div>

                                                        <!-- CLOUD RIGHT -->

                                                        <div class="tp-caption sfr"
                                                            data-x="820"
                                                            data-y="40"
                                                            data-start="1500"
                                                            data-speed="900"
                                                            data-width="283"
                                                            data-height="137">
                                                            <img src="../assets/img/tmp/slider/woman-cloud.png" alt="">
                                                        </div>

                                                        <!-- CLOUD LEFT -->

                                                        <div class="tp-caption sfl"
                                                            data-x="80"
                                                            data-y="200"
                                                            data-start="1500"
                                                            data-speed="900"
                                                            data-width="283"
                                                            data-height="137">
                                                            <img src="../assets/img/tmp/slider/woman-cloud.png" alt="">
                                                        </div>

                                                        <!-- TITLE -->

                                                        <div class="tp-caption sft"
                                                            data-x="80"
                                                            data-y="50"
                                                            data-start="1500"
                                                            data-speed="900"
                                                            data-width="283"
                                                            data-height="137">

                                                            <h2 class="rs-important-title">قالب فارسی تک صفحه ای</h2>

                                                        </div>

                                                        <!-- SUBTITLE -->

                                                        <div class="tp-caption sft"
                                                            data-x="80"
                                                            data-y="110"
                                                            data-start="1900"
                                                            data-speed="900"
                                                            data-width="283"
                                                            data-height="137">

                                                            <h3 class="rs-medium-title">آموزش طراحی سایت پیشرفته</h3>

                                                        </div>

                                                        <!-- PARAGRAPH -->

                                                        <div class="tp-caption sft"
                                                            data-x="80"
                                                            data-y="200"
                                                            data-start="2300"
                                                            data-speed="900"
                                                            data-width="283"
                                                            data-height="137">
                                                            <p class="rs-paragraph">
                                                                گروه آموزشی طلوع
                                                        <br>
                                                                آموزش برنامه نویسی و طراحی سایت
                                                        <br>
                                                                دانلود فایل های آموزشی رایگان
                                                        <br>
                                                                آیا نمی دانید از کجا شروع کنید؟
                                                        <br>
                                                                باما ارتباط برقرار کنید تا به نتیجه دلخواه خود برسید.
                                                            </p>
                                                        </div>

                                                        <!-- BUTTON -->

                                                        <div class="tp-caption sft"
                                                            data-x="80"
                                                            data-y="340"
                                                            data-start="2700"
                                                            data-speed="900"
                                                            data-width="283"
                                                            data-height="137">
                                                            <a href="http://tolooco.ir" class="btn btn-simple">بیشتر بدانید</a>
                                                        </div>

                                                        <div class="tp-bannertimer tp-bottom"></div>

                                                    </li>
                                                    <!-- MAN -->
                                                    <li data-transition="fade" data-masterspeed="0">
                                                        <img src="../assets/img/transparent.png" alt="">
                                                        <!-- MAN -->

                                                        <div class="tp-caption sfb"
                                                            data-x="255"
                                                            data-y="30"
                                                            data-speed="900"
                                                            data-width="543"
                                                            data-height="658">
                                                            <img src="../assets/img/tmp/slider/man.png" alt="">
                                                        </div>

                                                        <!-- TITLE -->

                                                        <div class="tp-caption sft"
                                                            data-start="2400"
                                                            data-x="center"
                                                            data-y="270"
                                                            data-speed="900">

                                                            <h2 class="rs-spectatular-title center">tolooco</h2>

                                                        </div>

                                                        <!-- SLOGAN -->

                                                        <div class="tp-caption sft"
                                                            data-start="2800"
                                                            data-x="center"
                                                            data-y="380"
                                                            data-speed="900">
                                                            <p class="rs-slogan center">
                                                                دانلود رایگان فایل های آموزش
                                                        <br>
                                                                برنامه نویسی - پایگاه داده - طراحی سایت.
                                                            </p>
                                                        </div>

                                                        <!-- BUTTON -->

                                                        <div class="tp-caption sft"
                                                            data-start="3200"
                                                            data-x="center"
                                                            data-y="440"
                                                            data-speed="900">

                                                            <div class="center">
                                                                <a href="http://tolooco.ir/" class="btn btn-simple">بیشتر بدانید
                                                                </a>
                                                            </div>

                                                            <!-- /.center -->
                                                        </div>

                                                        <div class="tp-bannertimer tp-bottom"></div>

                                                    </li>
                                                </ul>
                                            </div>

                                            <!-- /.tp-banner -->
                                        </div>

                                        <!-- /.tp-banner-container -->
                                    </div>

                                    <!-- /.navbar-title-wrapper -->
                                </div>

                                <!-- /.row -->
                            </div>

                            <!-- /.container -->
                        </div>

                        <!-- /.navbar-inner -->
                    </div>

                    <!-- /.navbar-outer -->
                </header>
                <!-- /.navbar-wrapper -->

                <div class="main">

                    <div class="container">

                        <div class="row">

                            <div class="col-sm-12 col-xs-12">
                                <!-- FEATURES -->

                                <div class="block-content features-wrapper">

                                    <div class="features">

                                        <div class="row">

                                            <div class="feature-item col-sm-4">

                                                <div class="fullwidth-left features-one">

                                                    <div class="center">
                                                        <a href="#">
                                                            <i class="features-icon fa fa-rocket" data-animation="bounce"></i>
                                                        </a>
                                                    </div>

                                                    <!-- /.center -->

                                                    <h2 class="feature-item-title center">HTML</h2>

                                                    <p class="feature-item-content center">سایت خود را انتخاب کنید و سفارش دهید</p>
                                                </div>

                                                <!-- /.features-one -->
                                            </div>

                                            <!-- /.col-sm-4 -->

                                            <div class="feature-item col-sm-4">

                                                <div class="features-two">

                                                    <div class="center">
                                                        <a href="#">
                                                            <i class="features-icon fa fa-check" data-animation="bounce"></i>
                                                        </a>
                                                    </div>

                                                    <!-- /.center -->

                                                    <h2 class="feature-item-title center">ASP.NET Webform</h2>

                                                    <p class="feature-item-content center">آموزش پیشرفته طراحی سایت</p>
                                                </div>

                                                <!-- /.features-two -->
                                            </div>

                                            <!-- /.col-sm-4 -->

                                            <div class="feature-item col-sm-4">

                                                <div class="features-three fullwidth-right">

                                                    <div class="center">
                                                        <a href="#">
                                                            <i class="features-icon fa fa-thumbs-up" data-animation="bounce"></i>
                                                        </a>
                                                    </div>

                                                    <!-- /.center -->

                                                    <h2 class="we-item-title center">ASP.NET MVC</h2>

                                                    <p class="feature-item-content center">آموزش پیشرفته طراحی سایت</p>
                                                </div>

                                                <!-- /.features-three -->
                                            </div>

                                            <!-- /.col-sm-4 -->
                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.features -->
                                </div>

                                <!-- /.features -->
                                <!-- SERVICES -->

                                <div id="menu-services" class="block-content services-wrapper block-padding">

                                    <div class="services">

                                        <h2 class="block-title center">سرویس ها</h2>

                                        <p class="slogan center">
                                            گروه آموزشی طلوع
                                    <br>
                                            این قالب تک صفحه ای فقط در سایت
                                    <a href="http://tolooco.ir">tolooco.ir</a>
                                        </p>

                                        <div class="row">

                                            <div class="col-sm-10 col-sm-offset-1">

                                                <div class="services-list row">

                                                    <div class="service col-sm-6">

                                                        <div class="row">

                                                            <div class="service-icon col-sm-4">

                                                                <div class="radial-icon-wrapper">

                                                                    <div class="radial-icon">

                                                                        <div class="radial-icon-inner">
                                                                            <i class="fa fa-rocket" data-animation="shake"></i>
                                                                        </div>

                                                                        <!-- /.radial-icon-inner -->
                                                                    </div>

                                                                    <!-- /.radial-icon -->
                                                                </div>

                                                                <!-- /.radial-icon-wrapper -->
                                                            </div>

                                                            <!-- /.service-icon -->

                                                            <div class="service-content col-sm-7">

                                                                <h2 class="service-title block-subtitle">طراحی منحصر به فرد</h2>

                                                                <p>
                                                                    آموزش طراحی سایت و برنامه نویسی.
                                                                </p>
                                                            </div>

                                                            <!-- /.service-content -->
                                                        </div>

                                                        <!-- /.row -->
                                                    </div>

                                                    <!-- /.service -->

                                                    <div class="service col-sm-6">

                                                        <div class="row">

                                                            <div class="service-icon col-sm-4">

                                                                <div class="radial-icon-wrapper">

                                                                    <div class="radial-icon">

                                                                        <div class="radial-icon-inner">
                                                                            <i class="fa fa-apple" data-animation="shake"></i>
                                                                        </div>

                                                                        <!-- /.radial-icon-inner -->
                                                                    </div>

                                                                    <!-- /.radial-icon -->
                                                                </div>

                                                                <!-- /.radial-icon-wrapper -->
                                                            </div>

                                                            <!-- /.service-icon -->

                                                            <div class="service-content col-sm-7">

                                                                <h2 class="service-title block-subtitle">قالب سایت</h2>

                                                                <p>
                                                                    قالب های راست چین و فارسی به سادگی دانلود کنید و لذت ببرید.
                                                                </p>
                                                            </div>

                                                            <!-- /.service-content -->
                                                        </div>

                                                        <!-- /.row -->
                                                    </div>

                                                    <!-- /.service -->

                                                    <div class="service col-sm-6">

                                                        <div class="row">

                                                            <div class="service-icon col-sm-4">

                                                                <div class="radial-icon-wrapper">

                                                                    <div class="radial-icon">

                                                                        <div class="radial-icon-inner">
                                                                            <i class="fa fa-thumbs-up" data-animation="shake"></i>
                                                                        </div>

                                                                        <!-- /.radial-icon-inner -->
                                                                    </div>

                                                                    <!-- /.radial-icon -->
                                                                </div>

                                                                <!-- /.radial-icon-wrapper -->
                                                            </div>

                                                            <!-- /.service-icon -->

                                                            <div class="service-content col-sm-7">

                                                                <h2 class="service-title block-subtitle">MVC</h2>

                                                                <p>
                                                                    طراحی وبسایت پیشرفته
                                                                </p>
                                                            </div>

                                                            <!-- /.service-content -->
                                                        </div>

                                                        <!-- /.row -->
                                                    </div>

                                                    <!-- /.service -->

                                                    <div class="service col-sm-6">

                                                        <div class="row">

                                                            <div class="service-icon col-sm-4">

                                                                <div class="radial-icon-wrapper">

                                                                    <div class="radial-icon">

                                                                        <div class="radial-icon-inner">
                                                                            <i class="fa fa-shopping-cart" data-animation="shake"></i>
                                                                        </div>

                                                                        <!-- /.radial-icon-inner -->
                                                                    </div>

                                                                    <!-- /.radial-icon -->
                                                                </div>

                                                                <!-- /.radial-icon-wrapper -->
                                                            </div>

                                                            <!-- /.service-icon -->

                                                            <div class="service-content col-sm-7">

                                                                <h2 class="service-title block-subtitle">تجارت الکترونیک</h2>

                                                                <p>
                                                                    به صورت اینترنتی انتخاب کنید، خرید کنید، طراحی کنید و به درآمد دلخواه خود برسید.
                                                                </p>
                                                            </div>

                                                            <!-- /.service-content -->
                                                        </div>

                                                        <!-- /.row -->
                                                    </div>

                                                    <!-- /.service -->
                                                </div>

                                                <!-- /.services-list -->
                                            </div>

                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.services -->
                                </div>

                                <!-- /.services-wrapper -->
                                <!-- RECENT WORKS -->

                                <div id="menu-works" class="block-content works-wrapper">

                                    <div class="works block-padding fullwidth background-gray">

                                        <h2 class="block-title center">نمونه کارها</h2>

                                        <ul class="works-filter">
                                            <li class="selected"><a href="#" data-filter="*"><span>همه</span></a></li>
                                            <li><a href="#" data-filter=".webdesign"><span>طراحی سایت</span></a></li>
                                            <li><a href="#" data-filter=".template"><span>برنامه نویسی</span></a></li>
                                            <li><a href="#" data-filter=".wordpress"><span>پایگاه داده</span></a></li>
                                        </ul>

                                        <div class="works-items row">

                                            <div class="work-item col-sm-4 webdesign">
                                                <a href="#" class="work-target">
                                                    <span class="work-detail-wrapper">
                                                        <span class="work-detail">
                                                            <span class="work-detail-icon">
                                                                <i class="fa fa-picture-o" data-animation="shake"></i>
                                                            </span>
                                                            <!-- /.work-detail-icon -->
                                                            <span class="work-detail-title">عنوان پروژه
                                                            </span>
                                                            <!-- /.work-detail-title -->
                                                            <span class="work-detail-button">
                                                                <span class="btn">مشاهده کنید</span>
                                                            </span>
                                                            <!-- /.work-detail-button -->
                                                        </span>
                                                        <!-- /.work-detail -->
                                                    </span>
                                                    <!-- /.work-detail-wrapper -->
                                                    <img src="../assets/img/tmp/works/work1.jpg" alt="#" class="img-responsive">
                                                </a>
                                            </div>

                                            <!-- /.work-item -->

                                            <div class="work-item col-sm-4 template">
                                                <a href="#" class="work-target">
                                                    <span class="work-detail-wrapper">
                                                        <span class="work-detail">
                                                            <span class="work-detail-icon">
                                                                <i class="fa fa-picture-o" data-animation="shake"></i>
                                                            </span>
                                                            <!-- /.work-detail-icon -->
                                                            <span class="work-detail-title">عنوان پروژه
                                                            </span>
                                                            <!-- /.work-detail-title -->
                                                            <span class="work-detail-button">
                                                                <span class="btn">مشاهده کنید</span>
                                                            </span>
                                                            <!-- /.work-detail-button -->
                                                        </span>
                                                        <!-- /.work-detail -->
                                                    </span>
                                                    <!-- /.work-detail-wrapper -->
                                                    <img src="../assets/img/tmp/works/work2.jpg" alt="#" class="img-responsive">
                                                </a>
                                            </div>

                                            <!-- /.work-item -->

                                            <div class="work-item col-sm-4 wordpress">
                                                <a href="#" class="work-target">
                                                    <span class="work-detail-wrapper">
                                                        <span class="work-detail">
                                                            <span class="work-detail-icon">
                                                                <i class="fa fa-picture-o" data-animation="shake"></i>
                                                            </span>
                                                            <!-- /.work-detail-icon -->
                                                            <span class="work-detail-title">عنوان پروژه
                                                            </span>
                                                            <!-- /.work-detail-title -->
                                                            <span class="work-detail-button">
                                                                <span class="btn">مشاهده کنید</span>
                                                            </span>
                                                            <!-- /.work-detail-button -->
                                                        </span>
                                                        <!-- /.work-detail -->
                                                    </span>
                                                    <!-- /.work-detail-wrapper -->
                                                    <img src="../assets/img/tmp/works/work3.jpg" alt="#" class="img-responsive">
                                                </a>
                                            </div>

                                            <!-- /.work-item -->

                                            <div class="work-item col-sm-4 webdesign">
                                                <a href="#" class="work-target">
                                                    <span class="work-detail-wrapper">
                                                        <span class="work-detail">
                                                            <span class="work-detail-icon">
                                                                <i class="fa fa-picture-o" data-animation="shake"></i>
                                                            </span>
                                                            <!-- /.work-detail-icon -->
                                                            <span class="work-detail-title">عنوان پروژه
                                                            </span>
                                                            <!-- /.work-detail-title -->
                                                            <span class="work-detail-button">
                                                                <span class="btn">مشاهده کنید</span>
                                                            </span>
                                                            <!-- /.work-detail-button -->
                                                        </span>
                                                        <!-- /.work-detail -->
                                                    </span>
                                                    <!-- /.work-detail-wrapper -->
                                                    <img src="../assets/img/tmp/works/work4.jpg" alt="#" class="img-responsive">
                                                </a>
                                            </div>

                                            <!-- /.work-item -->

                                            <div class="work-item col-sm-4 template">
                                                <a href="#" class="work-target">
                                                    <span class="work-detail-wrapper">
                                                        <span class="work-detail">
                                                            <span class="work-detail-icon">
                                                                <i class="fa fa-picture-o" data-animation="shake"></i>
                                                            </span>
                                                            <!-- /.work-detail-icon -->
                                                            <span class="work-detail-title">عنوان پروژه
                                                            </span>
                                                            <!-- /.work-detail-title -->
                                                            <span class="work-detail-button">
                                                                <span class="btn">مشاهده کنید</span>
                                                            </span>
                                                            <!-- /.work-detail-button -->
                                                        </span>
                                                        <!-- /.work-detail -->
                                                    </span>
                                                    <!-- /.work-detail-wrapper -->
                                                    <img src="../assets/img/tmp/works/work5.jpg" alt="#" class="img-responsive">
                                                </a>
                                            </div>

                                            <!-- /.work-item -->

                                            <div class="work-item col-sm-4 wordpress">
                                                <a href="#" class="work-target">
                                                    <span class="work-detail-wrapper">
                                                        <span class="work-detail">
                                                            <span class="work-detail-icon">
                                                                <i class="fa fa-picture-o" data-animation="shake"></i>
                                                            </span>
                                                            <!-- /.work-detail-icon -->
                                                            <span class="work-detail-title">عنوان پروژه
                                                            </span>
                                                            <!-- /.work-detail-title -->
                                                            <span class="work-detail-button">
                                                                <span class="btn">مشاهده کنید</span>
                                                            </span>
                                                            <!-- /.work-detail-button -->
                                                        </span>
                                                        <!-- /.work-detail -->
                                                    </span>
                                                    <!-- /.work-detail-wrapper -->
                                                    <img src="../assets/img/tmp/works/work1.jpg" alt="#" class="img-responsive">
                                                </a>
                                            </div>

                                            <!-- /.work-item -->
                                        </div>

                                        <!-- /.works-items -->
                                    </div>

                                    <!-- /.works -->
                                </div>

                                <!-- /.works-wrapper -->
                                <!-- TWITTER -->

                                <div class="block-content twitter-wrapper fullwidth">

                                    <div class="twitter">

                                        <h2 class="twitter-title center">آخرین های تویتر</h2>

                                        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                                            <ol class="carousel-indicators">
                                                <li data-target="#carousel-example-generic" data-slide-to="0" class="twitter-bullet active"></li>
                                                <li data-target="#carousel-example-generic" data-slide-to="1" class="twitter-bullet"></li>
                                                <li data-target="#carousel-example-generic" data-slide-to="2" class="twitter-bullet"></li>
                                            </ol>

                                            <div class="carousel-inner">

                                                <div class="twitter-item item active">

                                                    <div class="twitter-content">
                                                        آخرین اخبار طراحی وبسایت در گروه آموزشی طلوع.  <a href="http://tolooco.ir">tolooco.ir</a> قالب های راست چین و فارسی به سادگی دانلود کنید و لذت ببرید.
                                                    </div>

                                                    <!-- /.twitter-content -->

                                                    <div class="twitter-name">
                                                        <a href="http://tolooco.ir">tolooco.ir</a>
                                                    </div>

                                                    <!-- /.twitter-name -->

                                                    <div class="twitter-time">
                                                        35 ثانیه قبل
                                                    </div>

                                                    <!-- /.twitter-time -->

                                                    <div class="center">
                                                        <a href="#" class="btn btn-primary">مارا دنبال کنید</a>
                                                    </div>

                                                    <!-- /.center -->
                                                </div>

                                                <!-- /.twitter-item -->

                                                <div class="twitter-item item">

                                                    <div class="twitter-content">
                                                        پنل کاربری واکنیش گرا برای طراحان و مشتریان در سایت <a href="http://tolooco.ir">tolooco.ir</a> که می توانند به صورت کاملا حرفه ای در سایت کار کرده و کسب درآمد کنند.
                                                    </div>

                                                    <!-- /.twitter-content -->

                                                    <div class="twitter-name">
                                                        <a href="http://tolooco.ir">tolooco.ir</a>
                                                    </div>

                                                    <!-- /.twitter-name -->

                                                    <div class="twitter-time">
                                                        10 ساعت قبل
                                                    </div>

                                                    <!-- /.twitter-time -->

                                                    <div class="center">
                                                        <a href="#" class="btn btn-primary">مارا دنبال کنید</a>
                                                    </div>

                                                    <!-- /.center -->
                                                </div>

                                                <!-- /.twitter-item -->

                                                <div class="twitter-item item">

                                                    <div class="twitter-content">
                                                        برنامه نویسی و طراحی وبسایت را در سایت طلوع فرا بگیرید
                                                    </div>

                                                    <!-- /.twitter-content -->

                                                    <div class="twitter-name">
                                                        <a href="http://tolooco.ir">tolooco.ir</a>
                                                    </div>

                                                    <!-- /.twitter-name -->

                                                    <div class="twitter-time">
                                                        1 روز پیش
                                                    </div>

                                                    <!-- /.twitter-time -->

                                                    <div class="center">
                                                        <a href="#" class="btn btn-primary">مارا دنبال کنید</a>
                                                    </div>

                                                    <!-- /.center -->
                                                </div>

                                                <!-- /.twitter-item -->
                                            </div>

                                            <!-- /.carousel-inner -->
                                        </div>

                                        <!-- /.carousel -->
                                    </div>

                                    <!-- /.twitter -->
                                </div>

                                <!-- /.twitter-wrapper -->
                                <!-- PRICING -->

                                <div id="menu-pricing" class="block-content pricing-wrapper block-padding">

                                    <div class="pricing">

                                        <h2 class="block-title center">جدول قیمت ها</h2>

                                        <p class="pricing-slogan slogan center">
                                            قیمت ها یکی از مهمترین عوامل تاثیر گزار در انتخاب برای سایت شما می باشد، اما به یاد داشته باشید که پایین ترین قیمت همیشه بهترین نیست.
                                        </p>

                                        <div class="row">

                                            <div class="pricing-column-wrapper col-sm-4">

                                                <div class="pricing-column">

                                                    <h2 class="pricing-column-title">Html</h2>

                                                    <h3 class="pricing-column-subtitle">200 تا 300 هزار تومان</h3>

                                                    <div class="pricing-content">
                                                        <ul class="unstyled pricing-list">
                                                            <li>طراحی</li>
                                                            <li>شخصی سازی</li>
                                                            <li>فارسی سازی</li>
                                                            <li>بهینه سازی برای متورهای جستجو</li>
                                                            <li>پشتیبانی رایگان</li>
                                                        </ul>
                                                        <!-- /.pricing-list -->
                                                        <a href="http://tolooco.ir/article/2/Website-Design-and-Development.html" class="btn btn-primary">سفارش دهید</a>
                                                    </div>

                                                    <!-- /.pricing-content -->
                                                </div>

                                                <!-- /.pricing-column -->
                                            </div>

                                            <!-- /.pricing-column-wrapper -->

                                            <div class="pricing-column-wrapper col-sm-4">

                                                <div class="pricing-column featured">

                                                    <h2 class="pricing-column-title">ASP.NET Webform</h2>

                                                    <h3 class="pricing-column-subtitle">700 تا 800 هزار تومان</h3>

                                                    <div class="pricing-content">
                                                        <ul class="unstyled pricing-list">
                                                            <li>طراحی و پیاده سازی</li>
                                                            <li>محتوای داینامیک</li>
                                                            <li>هاست رایگان</li>
                                                            <li>دامنه ir رایگان</li>
                                                            <li>پشتیبانی رایگان</li>
                                                        </ul>
                                                        <!-- /.pricing-list -->
                                                        <a href="#" class="btn btn-warning">سفارش دهید</a>
                                                    </div>

                                                    <!-- /.pricing-content -->
                                                </div>

                                                <!-- /.pricing-column -->
                                            </div>

                                            <!-- /.pricing-column-wrapper -->

                                            <div class="pricing-column-wrapper col-sm-4">

                                                <div class="pricing-column">

                                                    <h2 class="pricing-column-title">ASP.NET MVC</h2>

                                                    <h3 class="pricing-column-subtitle">1,200 هزار تومان به بالا</h3>

                                                    <div class="pricing-content">
                                                        <ul class="unstyled pricing-list">
                                                            <li>طراحی توسعه و برنامه نویسی</li>
                                                            <li>محتوای داینامیک</li>
                                                            <li>هست رایگان</li>
                                                            <li>دامنه رایگان</li>
                                                            <li>پشتیبانی رایگان</li>
                                                        </ul>
                                                        <!-- /.pricing-list -->
                                                        <a href="#" class="btn btn-primary">سفراش سایت</a>
                                                    </div>

                                                    <!-- /.pricing-content -->
                                                </div>

                                                <!-- /.pricing-column -->
                                            </div>

                                            <!-- /.pricing-column-wrapper -->
                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.pricing -->
                                </div>

                                <!-- /.pricing-wrapper -->
                                <!-- ABOUT -->

                                <div class="block-content about-wrapper block-padding-large">

                                    <div class="about">

                                        <div class="row">

                                            <div class="col-sm-12">

                                                <h2 class="block-title">درباره ما</h2>

                                                <p class="slogan about-slogan">
                                                    اطلاعات درباره ما اطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره مااطلاعات درباره ما
                                                </p>
                                                <a href="http://tolooco.ir/article/1/About-us.html" class="btn btn-fancy">
                                                    <span>بیشتر بدانید</span>
                                                </a>
                                            </div>

                                            <!-- /.col-sm-6 -->

                                            <div class="about-picture col-sm-6"></div>

                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.about -->
                                </div>

                                <!-- /.about-wrapper -->
                                <!-- RECENT POSTS -->

                                <div id="menu-blog" class="block-content recent-posts-wrapper">

                                    <div class="recent-posts block-padding fullwidth background-gray">

                                        <h2 class="block-title center">پست های اخیر</h2>

                                        <p class="slogan center">
                                            گروه آموزشی طلوع
                                        </p>

                                        <div class="posts-wrapper">

                                            <div class="row">

                                                <div class="post-box-wrapper col-sm-4">

                                                    <div class="post-box">

                                                        <div class="post-box-image">
                                                            <a href="#" class="post-box-image-taget">
                                                                <img src="../assets/img/tmp/posts/post-1.jpg" alt="#" class="img-reponsive">
                                                            </a>
                                                        </div>

                                                        <!-- /.post-box-image -->

                                                        <div class="post-box-content">

                                                            <h3 class="post-box-title">
                                                                <a href="#">آموزش برنامه نویسی</a>
                                                            </h3>

                                                            <div class="post-box-author">
                                                                توسط <a href="#" class="author-target">حسین صادقی</a> <span class="separator">/</span> <span class="date">January 25, 2014</span>
                                                            </div>

                                                            <!-- /.post-box-author -->
                                                            <p>
                                                                میخواهید برنامه نویسی شوید؟ ما با شما همراه هستیم
                                                            </p>

                                                            <div class="post-box-meta">

                                                                <div class="row">

                                                                    <div class="post-box-comments col-sm-6">
                                                                        <a href="#">10 نظر</a>
                                                                    </div>

                                                                    <!-- /.post-box-comments -->

                                                                    <div class="post-box-category col-sm-6">
                                                                        <a href="#">Design</a> Category
                                                                    </div>

                                                                    <!-- /.post-box-category -->
                                                                </div>

                                                                <!-- /.row -->
                                                            </div>

                                                            <!-- /.post-box-meta -->
                                                        </div>

                                                        <!-- /.post-box-content -->
                                                    </div>

                                                    <!-- /.post-box -->
                                                </div>

                                                <!-- /.post-box-wrapper -->

                                                <div class="post-box-wrapper col-sm-4">

                                                    <div class="post-box">

                                                        <div class="post-box-image">
                                                            <a href="#" class="post-box-image-taget">
                                                                <img src="../assets/img/tmp/posts/post-1.jpg" alt="#" class="img-reponsive">
                                                            </a>
                                                        </div>

                                                        <!-- /.post-box-image -->

                                                        <div class="post-box-content">

                                                            <h3 class="post-box-title">
                                                                <a href="#">طراحی سایت</a>
                                                            </h3>

                                                            <div class="post-box-author">
                                                                توسط <a href="#" class="author-target">احمد حسام زاده</a> <span class="separator">/</span> <span class="date">January 25, 2014</span>
                                                            </div>

                                                            <!-- /.post-box-author -->
                                                            <p>
                                                                با آخرین تکنولوژی های روز دنیا در طراحی وبسایت باز هم در کنار شما هستیم
                                                            </p>

                                                            <div class="post-box-meta">

                                                                <div class="row">

                                                                    <div class="post-box-comments col-sm-6">
                                                                        <a href="#">167 نظر</a>
                                                                    </div>

                                                                    <!-- /.post-box-comments -->

                                                                    <div class="post-box-category col-sm-6">
                                                                        <a href="#">Video</a> Category
                                                                    </div>

                                                                    <!-- /.post-box-category -->
                                                                </div>

                                                                <!-- /.row -->
                                                            </div>

                                                            <!-- /.post-box-meta -->
                                                        </div>

                                                        <!-- /.post-box-content -->
                                                    </div>

                                                    <!-- /.post-box -->
                                                </div>

                                                <!-- /.post-box-wrapper -->

                                                <div class="post-box-wrapper col-sm-4">

                                                    <div class="post-box">

                                                        <div class="post-box-image">
                                                            <a href="#" class="post-box-image-taget">
                                                                <img src="../assets/img/tmp/posts/post-1.jpg" alt="#" class="img-reponsive">
                                                            </a>
                                                        </div>

                                                        <!-- /.post-box-image -->

                                                        <div class="post-box-content">

                                                            <h3 class="post-box-title">
                                                                <a href="#">بانک اطلاعات </a>
                                                            </h3>

                                                            <div class="post-box-author">
                                                                by <a href="#" class="author-target">علی جهانشیری</a> <span class="separator">/</span> <span class="date">January 25, 2014</span>
                                                            </div>

                                                            <!-- /.post-box-author -->
                                                            <p>
                                                                تکنیک های مختلف مدیریت پایگاه داده را با ما تجربه نمائید.
                                                            </p>

                                                            <div class="post-box-meta">

                                                                <div class="row">

                                                                    <div class="post-box-comments col-sm-6">
                                                                        <a href="#">55 Comments</a>
                                                                    </div>

                                                                    <!-- /.post-box-comments -->

                                                                    <div class="post-box-category col-sm-6">
                                                                        <a href="#">Photo</a> Category
                                                                    </div>

                                                                    <!-- /.post-box-category -->
                                                                </div>

                                                                <!-- /.row -->
                                                            </div>

                                                            <!-- /.post-box-meta -->
                                                        </div>

                                                        <!-- /.post-box-content -->
                                                    </div>

                                                    <!-- /.post-box -->
                                                </div>

                                                <!-- /.post-box-wrapper -->
                                            </div>

                                            <!-- /.row -->
                                        </div>

                                        <!-- /.posts-wrapper -->
                                    </div>

                                    <!-- /.recent-posts -->
                                </div>

                                <!-- /.recent-posts-wrapper -->
                                <!-- FEATURES -->

                                <div class="block-content features-simple-wrapper block-padding fullwidth">

                                    <div class="features-simple">

                                        <div class="row">

                                            <div class="features-simple-block col-sm-4">

                                                <div class="center">

                                                    <div class="radial-icon-wrapper">

                                                        <div class="radial-icon">

                                                            <div class="radial-icon-inner">
                                                                <i class="fa fa-rocket" data-animation="shake"></i>
                                                            </div>

                                                            <!-- /.radial-icon-inner -->
                                                        </div>

                                                        <!-- /.radial-icon -->
                                                    </div>

                                                    <!-- /.radial-icon-wrapper -->
                                                </div>

                                                <!-- /.center -->

                                                <h2 class="block-subtitle center">طراحی منحصر به فرد</h2>

                                                <p class="center">
                                                    سایت خود را انتخاب کنید و سفارش دهید با بهترین قیمت در کوتاه ترین زمان تحویل بگیرید.
                                                </p>
                                            </div>

                                            <!-- /.features-simple-block -->

                                            <div class="features-simple-block col-sm-4">

                                                <div class="center">

                                                    <div class="radial-icon-wrapper">

                                                        <div class="radial-icon">

                                                            <div class="radial-icon-inner">
                                                                <i class="fa fa-check" data-animation="shake"></i>
                                                            </div>

                                                            <!-- /.radial-icon-inner -->
                                                        </div>

                                                        <!-- /.radial-icon -->
                                                    </div>

                                                    <!-- /.radial-icon-wrapper -->
                                                </div>

                                                <!-- /.center -->

                                                <h2 class="block-subtitle center">قالب سایت</h2>

                                                <p class="center">
                                                    قالب های راست چین و فارسی به سادگی دانلود کنید و لذت ببرید.
                                                </p>
                                            </div>

                                            <!-- /.features-simple-block -->

                                            <div class="features-simple-block col-sm-4">

                                                <div class="center">

                                                    <div class="radial-icon-wrapper">

                                                        <div class="radial-icon">

                                                            <div class="radial-icon-inner">
                                                                <i class="fa fa-thumbs-up" data-animation="shake"></i>
                                                            </div>

                                                            <!-- /.radial-icon-inner -->
                                                        </div>

                                                        <!-- /.radial-icon -->
                                                    </div>

                                                    <!-- /.radial-icon-wrapper -->
                                                </div>

                                                <!-- /.center -->

                                                <h2 class="block-subtitle center">برنامه نویسی</h2>

                                                <p class="center">
                                                    از ما کمک بخواهید.
                                                </p>
                                            </div>

                                            <!-- /.features-simple-block -->
                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.features-simple -->
                                </div>

                                <!-- /.features-simple -->
                                <!-- CREATIVE SERVICES -->

                                <div class="block-content background-gray block-padding fullwidth">

                                    <h2 class="center block-title">سرویس های ویژه</h2>

                                    <p class="center slogan mb50">
                                        جدید ترین سیستم کسب درآمد آنلاین برای طراحان و برنامه نویسان وب را با ما تجربه کنید.
                                <br>
                                        مشتریان ما می توانند سایت مورد نظر خود را سفارش دهند تا در کمترین زمان و بهترین قیمت به نتیجه مطلوب خود برسند.
                                    </p>
                                    <p class="center">
                                        <a href="http://tolooco.ir" class="btn btn-fancy"><span>بیشتر بدانید</span></a>
                                    </p>
                                </div>

                                <!-- /.background-gray -->
                                <!-- WHAT WE DO -->

                                <div class="block-content block-padding">

                                    <div class="row">

                                        <div class="col-sm-6">

                                            <div class="progressbar-wrapper pull-left">
                                                <i class="percentage-icon fa fa-tint"></i>

                                                <div class="progressbar-inner">

                                                    <div class="progressbar" style="height: 82%">
                                                        <span class="progressbar-percentage">82%</span>
                                                    </div>

                                                    <!-- /.progressbar -->
                                                </div>

                                                <!-- /.progressbar-inner -->
                                            </div>

                                            <!-- /.progressbar-wrapper -->

                                            <div class="progressbar-wrapper purple pull-left">
                                                <i class="percentage-icon fa fa-tint"></i>

                                                <div class="progressbar-inner">

                                                    <div class="progressbar" style="height: 60%">
                                                        <span class="progressbar-percentage">60%</span>
                                                    </div>

                                                    <!-- /.progressbar -->
                                                </div>

                                                <!-- /.progressbar-inner -->
                                            </div>

                                            <!-- /.progressbar-wrapper -->

                                            <div class="progressbar-wrapper orange pull-left">
                                                <i class="percentage-icon fa fa-tint"></i>

                                                <div class="progressbar-inner">

                                                    <div class="progressbar" style="height: 94%">
                                                        <span class="progressbar-percentage">94%</span>
                                                    </div>

                                                    <!-- /.progressbar -->
                                                </div>

                                                <!-- /.progressbar-inner -->
                                            </div>

                                            <!-- /.progressbar-wrapper -->

                                            <div class="progressbar-wrapper blue pull-left">
                                                <i class="percentage-icon fa fa-tint"></i>

                                                <div class="progressbar-inner">

                                                    <div class="progressbar" style="height: 77%">
                                                        <span class="progressbar-percentage">77%</span>
                                                    </div>

                                                    <!-- /.progressbar -->
                                                </div>

                                                <!-- /.progressbar-inner -->
                                            </div>

                                            <!-- /.progressbar-wrapper -->
                                        </div>

                                        <!-- /.col-sm-6 -->

                                        <div class="col-sm-6">

                                            <h2 class="block-title">فعالیت های ما</h2>

                                            <p class="slogan">
                                                آموزش برنامه نویسی و طراحی وبسایت بصورت فارسی
                                            </p>
                                            <p class="slogan">
                                                آموزش های تصویری رایگان
                                            </p>
                                            <a href="http://tolooco.ir/" class="btn btn-fancy"><span>بیشتر بدانید</span></a>
                                        </div>

                                        <!-- /.col-sm-6 -->
                                    </div>

                                    <!-- /.row -->
                                </div>

                                <!-- /.block-padding -->
                                <!-- WHAT WE DO -->

                                <div class="block-content what-we-do-wrapper">

                                    <div class="what-we-do block-padding fullwidth">

                                        <h2 class="block-title center">فعالیت های ما</h2>

                                        <p class="what-we-do-slogan slogan center">
                                            ارائه آموزش در زمینه برنامه نویسی و طراحی سایت
                                        </p>

                                        <div class="row">

                                            <div class="chart-wrapper col-sm-4">

                                                <div class="chart center" data-percent="73" data-color=""><span class="chart-value">73%</span></div>

                                                <h2 class="block-subtitle center">فایل تصویری رایگان</h2>

                                                <p class="center">
                                                    انتخاب کنید مایل به یادگیری چه آموزش یا مهارتی هستید...
                                                </p>
                                            </div>

                                            <!-- /.chart-wrapper -->

                                            <div class="chart-wrapper col-sm-4">

                                                <div class="chart-orange center" data-percent="48" data-color=""><span class="chart-value">48%</span></div>

                                                <h2 class="block-subtitle center">آموزش آنلاین</h2>

                                                <p class="center">
                                                    ما درکنار شما خواهیم بود.
                                                </p>
                                            </div>

                                            <!-- /.chart-wrapper -->

                                            <div class="chart-wrapper col-sm-4">

                                                <div class="chart-blue center" data-percent="34" data-color=""><span class="chart-value">34%</span></div>

                                                <h2 class="block-subtitle center">آموزش خصوصی</h2>

                                                <p class="center">
                                                    با ما در تماس باشید
                                                </p>
                                            </div>

                                            <!-- /.chart-wrapper -->
                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.what-we-do -->
                                </div>

                                <!-- /.what-we-do-wrapper -->
                                <!-- CONTACT INFO-->

                                <div id="menu-contact" class="block-content features-simple-wrapper block-padding background-gray fullwidth">

                                    <div class="features-simple">

                                        <div class="row">

                                            <div class="features-simple-block col-sm-4">

                                                <div class="center">
                                                    <i class="features-simple-icon fa fa-map-marker"></i>
                                                </div>

                                                <!-- /.center -->

                                                <h2 class="block-subtitle center">آدرس</h2>

                                                <p class="center">
                                                    کرج - مهرشهر
                                                </p>
                                            </div>

                                            <!-- /.features-simple-block -->

                                            <div class="features-simple-block col-sm-4">

                                                <div class="center">
                                                    <i class="features-simple-icon fa fa-phone"></i>
                                                </div>

                                                <!-- /.center -->

                                                <h2 class="block-subtitle center">تلفن ها</h2>

                                                <p class="center" style="direction: ltr">
                                                    +98 26 3333 3333 - تلفن دفتر<br>
                                                    +98 26 3333 3333 - قکس
                                                </p>
                                            </div>

                                            <!-- /.features-simple-block -->

                                            <div class="features-simple-block col-sm-4">

                                                <div class="center">
                                                    <i class="features-simple-icon fa fa-envelope"></i>
                                                </div>

                                                <!-- /.center -->

                                                <h2 class="block-subtitle center">آدرس ایمیل</h2>

                                                <p class="center">
                                                    <a href="mailto:support@yourcompany.com">info@tolooco.ir</a>
                                                </p>
                                            </div>

                                            <!-- /.features-simple-block -->
                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.features-simple -->
                                </div>

                                <!-- /.features-simple -->
                                <!-- OUR LOCATION -->

                                <div class="block-content block-padding fullwidth">

                                    <h2 class="block-title center">موقعیت جغرافیای ما</h2>

                                    <p class="center slogan">
                                        فروش قالب های واکنش گرا و با استفاده از متود های طراحی روز دنیا. تمامی قالب های فروشی به صورت فارسی شده و کاملا راستچین ارائه می شود.
                                    </p>
                                </div>

                                <!-- /.block-padding -->

                                <div class="fullwidth-no-padding">
                                    <iframe class="block map-iframe" height="200" src="https://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=5th+Avenue,+New+York,+NY,+United+States&amp;aq=0&amp;oq=5th+ave&amp;sll=37.0625,-95.677068&amp;sspn=63.086946,135.087891&amp;ie=UTF8&amp;hq=5th+Avenue,+New+York,+NY,+United+States&amp;t=m&amp;ll=40.774578,-73.965181&amp;spn=0.006295,0.006295&amp;output=embed"></iframe>
                                </div>

                                <!-- /.fullwidth-no-padding -->
                                <!-- FEEDBACK -->

                                <div class="block-content block-padding fullwidth">

                                    <h2 class="block-title center">بازخورد</h2>

                                    <p class="center slogan mb50">
                                        نظرات و پیشنهادات خود را از این طریق برای ما ارسال کنید.
                                <br>
                                        درخواست های خود را از طریق ایمیل برای ما ارسال کنید.
                                    </p>
                                    <form method="post" action="http://html.heaven.pragmaticmates.com/one-page/index.html?">

                                        <div class="row">

                                            <div class="form-group col-sm-6">
                                                <input type="text" class="form-control" placeholder="نام خود را وارد کنید">
                                            </div>

                                            <!-- /.form-group -->

                                            <div class="form-group col-sm-6">
                                                <input type="email" class="form-control" placeholder="آدرس ایمیل خود را وارد کنید">
                                            </div>

                                            <!-- /.form-group -->
                                        </div>

                                        <div class="form-group">

                                            <div class="row">

                                                <div class="col-sm-12">
                                                    <textarea class="form-control" placeholder="متن پیام" rows="6"></textarea>
                                                </div>

                                            </div>

                                            <!-- /.row -->
                                        </div>

                                        <!-- /.form-group -->
                                        <input type="submit" value="Post message" class="btn btn-primary">
                                    </form>
                                </div>

                                <!-- /.block-padding -->
                                <!-- SUBSCRIBE -->

                                <div class="block-content subscribe-wrapper">

                                    <div class="subscribe background-gray block-padding fullwidth">

                                        <h2 class="block-title center">عضو خبر نامه شوید</h2>

                                        <div>

                                            <div class="row">

                                                <div class="form-group col-sm-9">
                                                    <input type="email" required="required" class="form-control" placeholder="آدرس ایمیل">
                                                </div>

                                                <!-- /.form-group -->

                                                <div class="col-sm-3 col-xs-12">
                                                    <button type="submit" class="btn btn-block btn-primary">اشتراک</button>
                                                </div>

                                                <div class="subscribe-promise col-sm-12">
                                                    <p><span class="required">*</span> امنیت اطلاعات شما را تضمین خواهیم کرد!</p>
                                                </div>

                                                <!-- /.promise -->
                                            </div>

                                            <!-- /.row -->
                                        </div>

                                    </div>

                                    <!-- /.subscribe -->
                                </div>

                                <!-- /.subscribe-wrapper -->
                                <!-- PARTNERS -->

                                <div class="block-content partners-wrapper">

                                    <div class="partners block-padding">

                                        <h2 class="block-title center">همکاران ما</h2>

                                        <p class="slogan center">
                                            در حال حاضر گروه توسعه دهندگان وب tolooco دارای سیستم های زیر می باشند و این سیستم ها را مدیریت می کنند.
                                        </p>

                                        <div class="partners-items row">

                                            <div class="partner-item col-sm-3 col-xs-12 center">
                                                <a href="http://tolooco.ir" class="partner-target">
                                                    <img src="../assets/img/tmp/logo/btemplate.png" alt="فروشگاه قالب سایت" class="img-responsive" style="width: 100%;">
                                                </a>
                                            </div>

                                            <!-- /.partner-item -->

                                            <div class="partner-item col-sm-3 col-xs-12 center">
                                                <a href="http://w3developers.ir" class="partner-target">
                                                    <img src="../assets/img/tmp/logo/bdevelopers.png" alt="طراحی سایت" class="img-responsive" style="width: 100%;">
                                                </a>
                                            </div>

                                            <!-- /.partner-item -->

                                            <div class="partner-item col-sm-3 col-xs-12 center">
                                                <a href="http://w3education.ir" class="partner-target">
                                                    <img src="../assets/img/tmp/logo/beducation.png" alt="آموزش طراحی سایت" class="img-responsive" style="width: 100%;">
                                                </a>
                                            </div>

                                            <!-- /.partner-item -->

                                            <div class="partner-item col-sm-3 col-xs-12 center">
                                                <a href="http://w3graphics.ir" class="partner-target">
                                                    <img src="../assets/img/tmp/logo/bgraphics.png" alt="طراحی گرافیکی" class="img-responsive" style="width: 100%;">
                                                </a>
                                            </div>

                                            <!-- /.partner-item -->
                                        </div>

                                    </div>

                                    <!-- /.subscribe -->
                                </div>

                                <!-- /.partners-wrapper -->
                            </div>

                            <!-- /.col-sm-12 -->
                        </div>

                        <!-- /.row -->
                    </div>

                    <!-- /.container -->
                </div>

                <!-- /.main -->
                <footer class="footer-wrapper">

                    <div class="footer-outer">

                        <div class="footer-inner">

                            <div class="footer">

                                <div class="footer-widgets">

                                    <div class="container">

                                        <div class="row">

                                            <div class="widget col-sm-2 col-xs-12 pull-right">

                                                <h2>منوی اصلی</h2>

                                                <ul class="nav">
                                                    <li class="item"><a href="#" class="item-target">صفحه اصلی</a></li>
                                                    <li class="item"><a href="#" class="item-target">درباره ما</a></li>
                                                    <li class="item"><a href="#" class="item-target">سوابق شغلی</a></li>
                                                    <li class="item"><a href="#" class="item-target">بلاگ</a></li>
                                                    <li class="item"><a href="#" class="item-target">تماس باما</a></li>
                                                </ul>
                                                <!-- /.nav-->
                                            </div>

                                            <!-- /.widget -->

                                            <div class="widget col-sm-3 col-xs-12 pull-right">

                                                <h2>شرکت</h2>

                                                <ul class="nav">
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">قوانین</a></li>
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">شرایط استفاده</a></li>
                                                    <li class="item"><a href="http://tolooco.ir/rss.xml" class="item-target">مطالب مطبوعاتی</a></li>
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">تیم ما</a></li>
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">مشاغل</a></li>
                                                </ul>
                                                <!-- /.nav -->
                                            </div>

                                            <!-- /.widget -->

                                            <div class="widget col-sm-3 col-col-xs-12 pull-right">

                                                <h2>راهنما و پشتیبانی</h2>

                                                <ul class="nav">
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">قوانین</a></li>
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">شرایط استفاده</a></li>
                                                    <li class="item"><a href="http://tolooco.ir/rss.xml" class="item-target">مطالب مطبوعاتی</a></li>
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">تیم ما</a></li>
                                                    <li class="item"><a href="http://tolooco.ir" class="item-target">مشاغل</a></li>
                                                </ul>
                                                <!-- /.nav -->
                                            </div>

                                            <!-- /.widget -->

                                            <div class="widget border-left col-sm-4 col-xs-12">

                                                <div class="col-sm-offset-1">

                                                    <h2>درباره سایت</h2>

                                                    <p>
                                                        این قالب بسیار زیبا یک قالب یک صفحه ای واکنش گرا است که با توجه به قالبلیت ها و اجزاء متفاوت آن، قالب را مناسب برای سایت های متفاوت کرده است و هر شرکتی می تواند برای معرفی سایت خود از این قالب استفاده کند. برای خرید این قالب فقط بر روی لینک زیر کلیک کنید.
                                                <br>
                                                        <a class="btn btn-primary" href="http://tolooco.ir">خرید آنلاین</a>
                                                    </p>
                                                </div>

                                            </div>

                                            <!-- /.widget -->
                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.container -->
                                </div>

                                <!-- /.footer-widgets -->

                                <div class="footer-copyright">

                                    <div class="container">

                                        <div class="row">

                                            <div class="col-xs-12">
                                                <p class="copyright">
                                                    &copy; طراحی و پیاده سازی <a href="http://tolooco.ir/">گروه آموزشی طلوع</a>
                                                </p>
                                                <ul class="social">
                                                    <!-- TWITTER -->
                                                    <li>
                                                        <a href="#" class="social-target">
                                                            <i class="fa fa-twitter"></i>
                                                        </a>
                                                    </li>
                                                    <!-- YOUTUBE -->
                                                    <li>
                                                        <a href="#" class="social-target">
                                                            <i class="fa fa-youtube"></i>
                                                        </a>
                                                    </li>
                                                    <!-- FLICKR -->
                                                    <li>
                                                        <a href="#" class="social-target">
                                                            <i class="fa fa-flickr"></i>
                                                        </a>
                                                    </li>
                                                    <!-- LINKEDIN -->
                                                    <li>
                                                        <a href="#" class="social-target">
                                                            <i class="fa fa-linkedin"></i>
                                                        </a>
                                                    </li>
                                                    <!-- GOOGLE+ -->
                                                    <li>
                                                        <a href="#" class="social-target">
                                                            <i class="fa fa-google-plus"></i>
                                                        </a>
                                                    </li>
                                                    <!-- SKYPE -->
                                                    <li>
                                                        <a href="#" class="social-target">
                                                            <i class="fa fa-skype"></i>
                                                        </a>
                                                    </li>
                                                    <!-- DRIBBBLE -->
                                                    <li>
                                                        <a href="#" class="social-target">
                                                            <i class="fa fa-dribbble"></i>
                                                        </a>
                                                    </li>
                                                </ul>
                                                <!-- /.social -->
                                            </div>

                                            <!-- /.col-xs-12 -->
                                        </div>

                                        <!-- /.row -->
                                    </div>

                                    <!-- /.container -->
                                </div>

                                <!-- /.copyright -->
                            </div>

                            <!-- /.footer -->
                        </div>

                        <!-- /.footer-inner -->
                    </div>

                    <!-- /.footer-outer -->
                </footer>
                <!-- /.footer-wrapper -->
            </div>

            <!-- /#wrapper -->

            <script type="text/javascript" src="../assets/js/jquery.js"></script>

            <script type="text/javascript" src="../assets/js/bootstrap.min.js"></script>

            <script type="text/javascript" src="../assets/js/jquery.viewport.min.js"></script>

            <script type="text/javascript" src="../assets/libraries/rendro-easy-pie-chart/dist/jquery.easypiechart.min.js"></script>

            <script type="text/javascript" src="../assets/libraries/isotope/jquery.isotope.min.js"></script>

            <script type="text/javascript" src="../assets/libraries/jquery-smooth-scroll/src/jquery.smooth-scroll.js"></script>

            <script type="text/javascript" src="../assets/libraries/rs-plugin/js/jquery.themepunch.plugins.min.js"></script>

            <script type="text/javascript" src="../assets/libraries/rs-plugin/js/jquery.themepunch.revolution.min.js"></script>

            <script type="text/javascript" src="../assets/js/heaven.js"></script>

        </form>
    </body>
</html>

