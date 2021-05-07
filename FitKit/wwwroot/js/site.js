// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// For the Tracker Page
function calories(ateCals, burnedCals) {
    var leftOverCals = parseInt(ateCals) - parseInt(burnedCals);
    alert(leftOverCals + " calorie(s) have not been used.");
}

// Accordion Code for Diet and Exercise Page
var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function () {
        /* Toggle between adding and removing the "active" class,
        to highlight the button that controls the panel */
        this.classList.toggle("active");

        /* Toggle between hiding and showing the active panel */
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
            panel.style.display = "none";
        } else {
            panel.style.display = "block";
        }
    });
}

$(function () {

    $("button.accordion").click(function () {
        $(this).next().slideToggle('slow', 'easeOutBounce');
    });

    $eachVid = $(".videos");

    $eachVid.fadeTo(3000, .25);

    $eachVid.hover(function () {

        $(this).stop().fadeTo("slow", 1);

    }, function () {

        $(this).stop().fadeTo("normal", .25);
    });

	var $logoPic = $(".logo");

	
	$logoPic.css({
		opacity: 0,
		position: "relative",
		left: -1500,
		zIndex: 2
	})
		.animate({
			opacity: 1,
			left: 0
		}, 2500, "easeOutElastic")

		.rotate({
			duration: 2500,
			angle: 0,
			center: [50, 50],
			animateTo: -360
		});

	var $homeText = $(".HomeCol1");

	$homeText.css({
		opacity: 0,
		position: "relative",
		top: -500,
		zIndex: 1
	})
		.animate({
			opacity: 1,
			top: 1
		}, 2500, "easeOutElastic");

});
