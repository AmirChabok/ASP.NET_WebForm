<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Error404.aspx.cs" Inherits="Errors_Error404__" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">

        <title>tolooco.ir</title>

        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
        <link href='http://fonts.googleapis.com/css?family=Roboto:400,100,100italic,300,300italic,400italic,500,500italic,700,700italic' rel='stylesheet' type='text/css'>

        <link rel="stylesheet" type="text/css" href="../css/bootstrap.css" media="screen">
        <!-- REVOLUTION BANNER CSS SETTINGS -->
        <link rel="stylesheet" type="text/css" href="../css/fullwidth.css" media="screen" />
        <link rel="stylesheet" type="text/css" href="../css/settings.css" media="screen" />
        <link rel="stylesheet" type="text/css" href="../css/magnific-popup.css" media="screen">
        <link rel="stylesheet" type="text/css" href="../css/owl.carousel.css" media="screen">
        <link rel="stylesheet" type="text/css" href="../css/owl.theme.css" media="screen">
        <link rel="stylesheet" type="text/css" href="../css/jquery.bxslider.css" media="screen">
        <link rel="stylesheet" type="text/css" href="../css/font-awesome.css" media="screen">
        <link rel="stylesheet" type="text/css" href="../css/animate.css" media="screen">
        <link rel="stylesheet" type="text/css" href="../css/style.css" media="screen">
        <link rel="stylesheet" type="text/css" href="../css/responsive.css" media="screen">

        <script type="text/javascript" src="../js/jquery.min.js"></script>

        <script type="text/javascript" src="../js/jquery.migrate.js"></script>

        <script type="text/javascript" src="../js/jquery.magnific-popup.min.js"></script>

        <script type="text/javascript" src="../js/bootstrap.js"></script>

        <script type="text/javascript" src="../js/owl.carousel.min.js"></script>

        <script type="text/javascript" src="../js/retina-1.1.0.min.js"></script>

        <script type="text/javascript" src="../js/jquery.bxslider.min.js"></script>

        <script type="text/javascript" src="../js/plugins-scroll.js"></script>

        <script type="text/javascript" src="../js/waypoint.min.js"></script>

        <script type="text/javascript" src="../js/script.js"></script>

        <!-- jQuery KenBurn Slider  -->

        <script type="text/javascript" src="../js/jquery.themepunch.revolution.min.js"></script>

        <script type="text/javascript" src="../js/script.js"></script>

    </head>
    <body>
        <form id="form1" runat="server">
            <!-- Container -->

            <div id="container" runat="server" align="center">
                <!-- Header
		    ================================================== -->
                <header class="clearfix">
                    <!-- Static navbar -->

                    <div class="navbar navbar-default navbar-fixed-top">

                        <div class="top-line">

                            <div class="container">
                                <%-- <ul class="top-menu">
                                    <li><a href="#"><i class="fa fa-arrow-circle-right"></i>شرایط و ضوابط</a></li>
                                    <li><a href="#"><i class="fa fa-arrow-circle-right"></i>درباره ما</a></li>
                                    <li><a href="#"><i class="fa fa-arrow-circle-right"></i>ثبت نام</a></li>
                                    <li><a href="#"><i class="fa fa-arrow-circle-right"></i>ورود</a></li>
                                    <li><a href="#"><i class="fa fa-arrow-circle-right"></i>ارتباط با ما</a></li>
                                </ul>--%>
                                <ul class="social-icons">
                                    <li><a class="facebook" href="#"><i class="fa fa-facebook"></i></a></li>
                                    <li><a class="twitter" href="#"><i class="fa fa-twitter"></i></a></li>
                                    <li><a class="rss" href="#"><i class="fa fa-rss"></i></a></li>
                                    <li><a class="google" href="#"><i class="fa fa-google-plus"></i></a></li>
                                    <li><a class="linkedin" href="#"><i class="fa fa-linkedin"></i></a></li>
                                    <li><a class="pinterest" href="#"><i class="fa fa-pinterest"></i></a></li>
                                </ul>
                            </div>

                        </div>

                        <div class="container">

                            <div class="navbar-header">
                                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </button>
                            </div>

                          <div class="navbar-collapse collapse">
                                <ul>
                                    <li>
                                        <a class="active" href="../Default.aspx"><span></span>
                                         <asp:Label ID="Label1" runat="server" CssClass="form-control" Text="<%$Resources:Captions,Home%>" />
                                        </a>
                                    </li>
                                </ul>
                            </div>

                        </div>

                    </div>

                </header>
                <!-- End Header -->


                <!-- content 
			================================================== -->

                <div id="content">

                    <h1>
                        &nbsp
                        <asp:Label ID="lblError" runat="server" Text="<%$Resources:Captions,PageNotFound%>" />

                    </h1>


                </div>

            </div>




            <!-- End content -->




            <!-- End Container -->

            <!--
	##############################
	 - ACTIVATE THE BANNER HERE -
	##############################
	-->

            <script type="text/javascript">

                var tpj = jQuery;
                tpj.noConflict();

                tpj(document).ready(function () {

                    if (tpj.fn.cssOriginal != undefined)
                        tpj.fn.css = tpj.fn.cssOriginal;

                    var api = tpj('.fullwidthbanner').revolution(
                        {
                            delay: 8000,
                            startwidth: 1170,
                            startheight: 500,

                            onHoverStop: "off",						// Stop Banner Timet at Hover on Slide on/off

                            thumbWidth: 100,							// Thumb With and Height and Amount (only if navigation Tyope set to thumb !)
                            thumbHeight: 50,
                            thumbAmount: 3,

                            hideThumbs: 0,
                            navigationType: "none",				// bullet, thumb, none
                            navigationArrows: "solo",				// nexttobullets, solo (old name verticalcentered), none

                            navigationStyle: "round",				// round,square,navbar,round-old,square-old,navbar-old, or any from the list in the docu (choose between 50+ different item), custom


                            navigationHAlign: "center",				// Vertical Align top,center,bottom
                            navigationVAlign: "bottom",					// Horizontal Align left,center,right
                            navigationHOffset: 30,
                            navigationVOffset: 40,

                            soloArrowLeftHalign: "left",
                            soloArrowLeftValign: "center",
                            soloArrowLeftHOffset: 0,
                            soloArrowLeftVOffset: 0,

                            soloArrowRightHalign: "right",
                            soloArrowRightValign: "center",
                            soloArrowRightHOffset: 0,
                            soloArrowRightVOffset: 0,

                            touchenabled: "on",						// Enable Swipe Function : on/off


                            stopAtSlide: -1,							// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
                            stopAfterLoops: -1,						// Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic

                            hideCaptionAtLimit: 0,					// It Defines if a caption should be shown under a Screen Resolution ( Basod on The Width of Browser)
                            hideAllCaptionAtLilmit: 0,				// Hide all The Captions if Width of Browser is less then this value
                            hideSliderAtLimit: 0,					// Hide the whole slider, and stop also functions if Width of Browser is less than this value


                            fullWidth: "on",

                            shadow: 1								//0 = no Shadow, 1,2,3 = 3 Different Art of Shadows -  (No Shadow in Fullwidth Version !)

                        });


                    // TO HIDE THE ARROWS SEPERATLY FROM THE BULLETS, SOME TRICK HERE:
                    //  You can REMOVE IT FROM HERE TILL THE END OF THIS SECTION IF YOU DONT NEED THIS !
                    api.bind("revolution.slide.onloaded", function (e) {


                        jQuery('.tparrows').each(function () {
                            var arrows = jQuery(this);

                            var timer = setInterval(function () {

                                if (arrows.css('opacity') == 1 && !jQuery('.tp-simpleresponsive').hasClass("mouseisover"))
                                    arrows.fadeOut(300);
                            }, 3000);
                        })

                        jQuery('.tp-simpleresponsive, .tparrows').hover(function () {
                            jQuery('.tp-simpleresponsive').addClass("mouseisover");
                            jQuery('body').find('.tparrows').each(function () {
                                jQuery(this).fadeIn(300);
                            });
                        }, function () {
                            if (!jQuery(this).hasClass("tparrows"))
                                jQuery('.tp-simpleresponsive').removeClass("mouseisover");
                        })
                    });
                    // END OF THE SECTION, HIDE MY ARROWS SEPERATLY FROM THE BULLETS
                });
            </script>

        </form>
    </body>
</html>

