$(window).load(function() {
	'use strict';

	/******************************************************************************
	 * ISOTOPE
	 ******************************************************************************/
	var isotope_works = $('.works-items');
	isotope_works.isotope({});

	$('.works-filter a').click(function() {
		$(this).parent().parent().find('li').removeClass('selected');
		$(this).parent().addClass('selected');

  		var selector = $(this).attr('data-filter');
  		isotope_works.isotope({ filter: selector });
  		return false;
	});
});

$(document).ready(function() {
	'use strict';

	/******************************************************************************
	 * SMOOTH SCROLLING
	 ******************************************************************************/
	$('.navbar-nav a').smoothScroll({
		speed: 1000,
		offset: -75
	});

	/******************************************************************************
	 * VIEWPORT
	 ******************************************************************************/
 	checkViewPort();
    $(window).scroll(function () {
        checkViewPort();
    });

    function checkViewPort() {
        var link = '';
        var inview = $('.block-content:in-viewport:first').attr('id');
        var menuItems = $('.navbar-nav li');
        menuItems.each(function() {
        	var current_link = $('a', this);

            if (current_link.attr('href') == '#' + inview) {
            	current_link.parent().parent().find('li').removeClass('active');
                current_link.parent().addClass('active');                
            }
        });       
    }

	/******************************************************************************
	 * ANIMATION
	 ******************************************************************************/
	$('[data-animation]').each(function() {
		var el = $(this);
		$(this).hover(function() {
			$(this).addClass('animated');
			$(this).addClass(el.attr('data-animation'));
		}, function() {
			$(this).removeClass('animated');
			$(this).removeClass(el.attr('data-animation'));
		});
	});

	/******************************************************************************
	 * STICKY HEADER
	 ******************************************************************************/	 
	if ($('body').hasClass('sticky-header')) {
		$(window).scroll(function () { 
			if ($(this).scrollTop() > 0) {
				$('body').addClass('sticky-header-applied');
				$('.navbar').addClass('sticky');
			} else {
				$('body').removeClass('sticky-header-applied');
				$('.navbar').removeClass('sticky');
			}
		});
	}

	/******************************************************************************
	 * REVOLUTION SLIDER
	 ******************************************************************************/
	$('.rs-banner').revolution({
		delay: 5000,
		startwidth: 1170,
		startheight: 550,
		hideThumbs: 10,
		fullWidth: "on",
		forceFullWidth:"on"
	});

	/******************************************************************************
	 * CHARTS
	 ******************************************************************************/
	$('.chart').easyPieChart({
		barColor: '#59b91c',
		trackColor: '#e9edf2',
        scaleColor: false,
        lineWidth: 44,
        lineCap: 'butt',
        size: 200
    });

	$('.chart-orange').easyPieChart({
		barColor: '#f67616',
		trackColor: '#e9edf2',
        scaleColor: false,
        lineWidth: 44,
        lineCap: 'butt',
        size: 200
    }); 

	$('.chart-blue').easyPieChart({
		barColor: '#00a2e8',
		trackColor: '#e9edf2',
        scaleColor: false,
        lineWidth: 44,
        lineCap: 'butt',
        size: 200
    });          
});