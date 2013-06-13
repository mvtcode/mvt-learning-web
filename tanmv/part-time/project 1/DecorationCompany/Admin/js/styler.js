	var wt_styler = '';
	var wt_active = false;
	
	
	$(window).load(function() {
		$('#styler').fadeIn(1000);
		
		wt_active = true;
	});
		
		

	window.onload=function(){
	
		wt_styler = $('#styler');
		
		//var exp_panel_bar_selector = '.panel .title, .panel .title-large, .panel.wizard .header, .exp-stats .week th, .exp-stats .chart div div';
		var exp_panel_bar_selector = '.panel .title, .panel .title-large, .panel.wizard .header';
		var exp_panel_bar_cache = wt_styler_getVal('exp_panel_bar', '#019ddd');
		$(exp_panel_bar_selector).animate({ 'background-color' : exp_panel_bar_cache },1500);
		$("#panel-bar-color").attr('value', exp_panel_bar_cache);
		
		
		var exp_style_backgound_color_selector = 'body';
		var exp_style_backgound_color_cache = wt_styler_getVal('exp_background_color', '#525252');
		$(exp_style_backgound_color_selector).css('background', exp_style_backgound_color_cache);
		$("#style-backgound-color").attr('value', exp_style_backgound_color_cache);
		
		
		
		var exp_th_patternOpacity_selector = '#style-background';
		var exp_th_patternOpacity_cache = wt_styler_getVal('exp_th_patternOpacity', '0.4');
		$("#style-background-transparency").slider({ 
			from: 0, 
			to: 1, 
			step: 0.1, 
			round: 1, 
			dimension: '&nbsp;', 
			skin: "round_plastic",
			onstatechange: function(value) {
				if (wt_active){
					wt_styler_setVal('exp_th_patternOpacity', value);
					$(exp_th_patternOpacity_selector).css('opacity', value);
				}
			}});
		$("#style-background-transparency").slider('value', exp_th_patternOpacity_cache );	
		$(exp_th_patternOpacity_selector).css('opacity', exp_th_patternOpacity_cache );
		
		
		
		var exp_th_shadowOpacity_selector = '#style-shadow';
		var exp_th_shadowOpacity_cache = wt_styler_getVal('exp_th_shadowOpacity', '0.4');
		$("#style-background-shadow").slider({ 
			from: 0, 
			to: 1, 
			step: 0.1, 
			round: 1, 
			dimension: '&nbsp;', 
			skin: "round_plastic",
			onstatechange: function(value) {
				if (wt_active){
					wt_styler_setVal('exp_th_shadowOpacity', value);
					$(exp_th_shadowOpacity_selector).css('opacity', value);
				}
			}});
		$("#style-background-shadow").slider('value', exp_th_shadowOpacity_cache )
		$(exp_th_shadowOpacity_selector).css('opacity', exp_th_shadowOpacity_cache );	
		
		
		
		var exp_th_panelBarOpacity_selector = '.panel .theme';
		var exp_th_panelBarOpacity_cache = wt_styler_getVal('exp_th_panelBarOpacity', '0.4');
		$("#style-panelbar-opacity").slider({ 
			from: 0, 
			to: 1, 
			step: 0.1, 
			round: 1, 
			dimension: '&nbsp;', 
			skin: "round_plastic",
			onstatechange: function(value) {
				if (wt_active){
					wt_styler_setVal('exp_th_panelBarOpacity', value);
					$(exp_th_panelBarOpacity_selector).css('opacity', value);
				}
			}});
		$(exp_th_panelBarOpacity_selector).animate({ 'opacity' : exp_th_panelBarOpacity_cache },1500 );
		$("#style-panelbar-opacity").slider('value', exp_th_panelBarOpacity_cache )
		
		
		if ($('#styler.auto').length){
			$(wt_styler).delay(2000)
						.animate( {'top':0}, 250, function(){
							wt_styler_fadeTo(0.97);
						})
						.removeClass('auto')
						.addClass('on');
		}
		
		$('.handle', wt_styler).click(function(){
			if ( $(wt_styler).hasClass('off') ){
				$(wt_styler).animate( {'top':0}, 150)
							.removeClass('off')
							.addClass('on');
							
				wt_styler_fadeTo(0.97);
				return false;
			}
			
			if ( $(wt_styler).hasClass('on') ){
				$(wt_styler).animate( {'top':-85}, 150)
							.removeClass('on')
							.addClass('off');
							
				wt_styler_fadeTo(0.4);
				return false;
			}
		});
		
		
		
		
		
		
		$("#style-backgound-color").miniColors({
			change: function(hex) {
				$(exp_style_backgound_color_selector).css('background', hex);
				wt_styler_setVal('exp_background_color', hex);
				
			}
		});		
		
		$("#panel-bar-color").miniColors({
			change: function(hex) {
				$(exp_panel_bar_selector).css('background-color', hex);
				wt_styler_setVal('exp_panel_bar', hex);
				
			}
		});
		
		
	}
	
	
	
	function wt_styler_fadeTo(new_opacity){
		var speed = 'slow';
		
		$('.back-body', wt_styler).delay(250).animate({ opacity: new_opacity }, speed);
		$('.back-hand', wt_styler).delay(250).animate({ opacity: new_opacity }, speed);	
	}
	
	
	function wt_styler_setVal(wtKey, wtValue){
		$.cookie(wtKey, wtValue, { expires: 7 });
	}
	
	function wt_styler_getVal(wtValue, wtDefault){
		current_value = $.cookie(wtValue);
		
		if (current_value == null){
			$.cookie(wtValue, wtDefault, { expires: 7 } );
			//console.log( 'Styler settings [set] : '+wtValue+' = [' + wtDefault + ']' );
		}else{
			//console.log( 'Styler settings [get] : [' + current_value + ']' );
			return current_value;
		}
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
/**
 * Create a cookie with the given key and value and other optional parameters.
 *
 * @example $.cookie('the_cookie', 'the_value');
 * @desc Set the value of a cookie.
 *
 * @example $.cookie('the_cookie', 'the_value', { expires: 7, path: '/', domain: 'jquery.com', secure: true });
 * @desc Create a cookie with all available options.
 *
 * @example $.cookie('the_cookie', 'the_value');
 * @desc Create a session cookie.
 *
 * @example $.cookie('the_cookie', null);
 * @desc Delete a cookie by passing null as value. Keep in mind that you have to use the same path and domain
 *       used when the cookie was set.
 *
 * @example $.cookie('the_cookie');
 * @desc Get the value of a cookie.
 *
 */
jQuery.cookie = function (key, value, options) {
    
    // key and at least value given, set cookie...
    if (arguments.length > 1 && String(value) !== "[object Object]") {
        options = jQuery.extend({}, options);

        if (value === null || value === undefined) {
            options.expires = -1;
        }

        if (typeof options.expires === 'number') {
            var days = options.expires, t = options.expires = new Date();
            t.setDate(t.getDate() + days);
        }
        
        value = String(value);
        
        return (document.cookie = [
            encodeURIComponent(key), '=',
            options.raw ? value : encodeURIComponent(value),
            options.expires ? '; expires=' + options.expires.toUTCString() : '', // use expires attribute, max-age is not supported by IE
            options.path ? '; path=' + options.path : '',
            options.domain ? '; domain=' + options.domain : '',
            options.secure ? '; secure' : ''
        ].join(''));
    }

    options = value || {};
    var result, decode = options.raw ? function (s) { return s; } : decodeURIComponent;
    return (result = new RegExp('(?:^|; )' + encodeURIComponent(key) + '=([^;]*)').exec(document.cookie)) ? decode(result[1]) : null;
};


	
if(jQuery) (function($) {
	
	$.extend($.fn, {
		
		miniColors: function(o, data) {
			
			
			var create = function(input, o, data) {
				
				//
				// Creates a new instance of the miniColors selector
				//
				
				// Determine initial color (defaults to white)
				var color = cleanHex(input.val());
				if( !color ) color = 'FFFFFF';
				var hsb = hex2hsb(color);
				
				// Create trigger
				var trigger = $('<a class="miniColors-trigger" style="background-color: #' + color + '" href="#"></a>');
				trigger.insertAfter(input);
				
				// Add necessary attributes
				input.addClass('miniColors').attr('maxlength', 7).attr('autocomplete', 'off');
				
				// Set input data
				input.data('trigger', trigger);
				input.data('hsb', hsb);
				if( o.change ) input.data('change', o.change);
				
				// Handle options
				if( o.readonly ) input.attr('readonly', true);
				if( o.disabled ) disable(input);
				
				// Show selector when trigger is clicked
				trigger.bind('click.miniColors', function(event) {
					event.preventDefault();
					input.trigger('focus');
				});
				
				// Show selector when input receives focus
				input.bind('focus.miniColors', function(event) {
					show(input);
				});
				
				// Hide on blur
				input.bind('blur.miniColors', function(event) {
					var hex = cleanHex(input.val());
					input.val( hex ? '#' + hex : '' );
				});
				
				// Hide when tabbing out of the input
				input.bind('keydown.miniColors', function(event) {
					if( event.keyCode === 9 ) hide(input);
				});
				
				// Update when color is typed in
				input.bind('keyup.miniColors', function(event) {
					// Remove non-hex characters
					var filteredHex = input.val().replace(/[^A-F0-9#]/ig, '');
					input.val(filteredHex);
					if( !setColorFromInput(input) ) {
						// Reset trigger color when color is invalid
						input.data('trigger').css('backgroundColor', '#FFF');
					}
				});
				
				// Handle pasting
				input.bind('paste.miniColors', function(event) {
					// Short pause to wait for paste to complete
					setTimeout( function() {
						input.trigger('keyup');
					}, 5);
				});
				
			};
			
			
			var destroy = function(input) {
				
				//
				// Destroys an active instance of the miniColors selector
				//
				
				hide();
				
				input = $(input);
				input.data('trigger').remove();
				input.removeAttr('autocomplete');
				input.removeData('trigger');
				input.removeData('selector');
				input.removeData('hsb');
				input.removeData('huePicker');
				input.removeData('colorPicker');
				input.removeData('mousebutton');
				input.removeData('moving');
				input.unbind('click.miniColors');
				input.unbind('focus.miniColors');
				input.unbind('blur.miniColors');
				input.unbind('keyup.miniColors');
				input.unbind('keydown.miniColors');
				input.unbind('paste.miniColors');
				$(document).unbind('mousedown.miniColors');
				$(document).unbind('mousemove.miniColors');
				
			};
			
			
			var enable = function(input) {
				
				//
				// Disables the input control and the selector
				//
				
				input.attr('disabled', false);
				input.data('trigger').css('opacity', 1);
				
			};
			
			
			var disable = function(input) {
				
				//
				// Disables the input control and the selector
				//
				
				hide(input);
				input.attr('disabled', true);
				input.data('trigger').css('opacity', .5);
				
			};
			
			
			var show = function(input) {
				
				//
				// Shows the miniColors selector
				//
				
				if( input.attr('disabled') ) return false;
				
				// Hide all other instances 
				hide();				
				
				// Generate the selector
				var selector = $('<div class="miniColors-selector"></div>');
				selector.append('<div class="miniColors-colors" style="background-color: #FFF;"><div class="miniColors-colorPicker"></div></div>');
				selector.append('<div class="miniColors-hues"><div class="miniColors-huePicker"></div></div>');
				selector.css({
					top: input.is(':visible') ? input.offset().top + input.outerHeight() : input.data('trigger').offset().top + input.data('trigger').outerHeight(),
					left: input.is(':visible') ? input.offset().left : input.data('trigger').offset().left,
					display: 'none'
				}).addClass( input.attr('class') );
				
				// Set background for colors
				var hsb = input.data('hsb');
				selector.find('.miniColors-colors').css('backgroundColor', '#' + hsb2hex({ h: hsb.h, s: 100, b: 100 }));
				
				// Set colorPicker position
				var colorPosition = input.data('colorPosition');
				if( !colorPosition ) colorPosition = getColorPositionFromHSB(hsb);
				selector.find('.miniColors-colorPicker').css('top', colorPosition.y + 'px').css('left', colorPosition.x + 'px');
				
				// Set huePicker position
				var huePosition = input.data('huePosition');
				if( !huePosition ) huePosition = getHuePositionFromHSB(hsb);
				selector.find('.miniColors-huePicker').css('top', huePosition.y + 'px');
				
				
				// Set input data
				input.data('selector', selector);
				input.data('huePicker', selector.find('.miniColors-huePicker'));
				input.data('colorPicker', selector.find('.miniColors-colorPicker'));
				input.data('mousebutton', 0);
				
				$('BODY').append(selector);
				selector.fadeIn(100);
				
				// Prevent text selection in IE
				selector.bind('selectstart', function() { return false; });
				
				$(document).bind('mousedown.miniColors', function(event) {
					input.data('mousebutton', 1);
					
					if( $(event.target).parents().andSelf().hasClass('miniColors-colors') ) {
						event.preventDefault();
						input.data('moving', 'colors');
						moveColor(input, event);
					}
					
					if( $(event.target).parents().andSelf().hasClass('miniColors-hues') ) {
						event.preventDefault();
						input.data('moving', 'hues');
						moveHue(input, event);
					}
					
					if( $(event.target).parents().andSelf().hasClass('miniColors-selector') ) {
						event.preventDefault();
						return;
					}
					
					if( $(event.target).parents().andSelf().hasClass('miniColors') ) return;
					
					hide(input);
				});
				
				$(document).bind('mouseup.miniColors', function(event) {
					input.data('mousebutton', 0);
					input.removeData('moving');
				});
				
				$(document).bind('mousemove.miniColors', function(event) {
					if( input.data('mousebutton') === 1 ) {
						if( input.data('moving') === 'colors' ) moveColor(input, event);
						if( input.data('moving') === 'hues' ) moveHue(input, event);
					}
				});
				
			};
			
			
			var hide = function(input) {
				
				//
				// Hides one or more miniColors selectors
				//
				
				// Hide all other instances if input isn't specified
				if( !input ) input = '.miniColors';
				
				$(input).each( function() {
					var selector = $(this).data('selector');
					$(this).removeData('selector');
					$(selector).fadeOut(100, function() {
						$(this).remove();
					});
				});
				
				$(document).unbind('mousedown.miniColors');
				$(document).unbind('mousemove.miniColors');
				
			};
			
			
			var moveColor = function(input, event) {
				
				var colorPicker = input.data('colorPicker');
				
				colorPicker.hide();
				
				var position = {
					x: event.clientX - input.data('selector').find('.miniColors-colors').offset().left + $(document).scrollLeft() - 5,
					y: event.clientY - input.data('selector').find('.miniColors-colors').offset().top + $(document).scrollTop() - 5
				};
				
				if( position.x <= -5 ) position.x = -5;
				if( position.x >= 144 ) position.x = 144;
				if( position.y <= -5 ) position.y = -5;
				if( position.y >= 144 ) position.y = 144;
				input.data('colorPosition', position);
				colorPicker.css('left', position.x).css('top', position.y).show();
				
				// Calculate saturation
				var s = Math.round((position.x + 5) * .67);
				if( s < 0 ) s = 0;
				if( s > 100 ) s = 100;
				
				// Calculate brightness
				var b = 100 - Math.round((position.y + 5) * .67);
				if( b < 0 ) b = 0;
				if( b > 100 ) b = 100;
				
				// Update HSB values
				var hsb = input.data('hsb');
				hsb.s = s;
				hsb.b = b;
				
				// Set color
				setColor(input, hsb, true);
				
			};
			
			
			var moveHue = function(input, event) {
				
				var huePicker = input.data('huePicker');
				
				huePicker.hide();
				
				var position = {
					y: event.clientY - input.data('selector').find('.miniColors-colors').offset().top + $(document).scrollTop() - 1
				};
				
				if( position.y <= -1 ) position.y = -1;
				if( position.y >= 149 ) position.y = 149;
				input.data('huePosition', position);
				huePicker.css('top', position.y).show();
				
				// Calculate hue
				var h = Math.round((150 - position.y - 1) * 2.4);
				if( h < 0 ) h = 0;
				if( h > 360 ) h = 360;
				
				// Update HSB values
				var hsb = input.data('hsb');
				hsb.h = h;
				
				// Set color
				setColor(input, hsb, true);
				
			};
			
			
			var setColor = function(input, hsb, updateInputValue) {
				
				input.data('hsb', hsb);
				var hex = hsb2hex(hsb);	
				if( updateInputValue ) input.val('#' + hex);
				input.data('trigger').css('backgroundColor', '#' + hex);
				if( input.data('selector') ) input.data('selector').find('.miniColors-colors').css('backgroundColor', '#' + hsb2hex({ h: hsb.h, s: 100, b: 100 }));
				
				if( input.data('change') ) {
					input.data('change').call(input, '#' + hex, hsb2rgb(hsb));
				}
				
			};
			
			
			var setColorFromInput = function(input) {
				
				// Don't update if the hex color is invalid
				var hex = cleanHex(input.val());
				if( !hex ) return false;
				
				// Get HSB equivalent
				var hsb = hex2hsb(hex);
				
				// If color is the same, no change required
				var currentHSB = input.data('hsb');
				if( hsb.h === currentHSB.h && hsb.s === currentHSB.s && hsb.b === currentHSB.b ) return true;
				
				// Set colorPicker position
				var colorPosition = getColorPositionFromHSB(hsb);
				var colorPicker = $(input.data('colorPicker'));
				colorPicker.css('top', colorPosition.y + 'px').css('left', colorPosition.x + 'px');
				
				// Set huePosition position
				var huePosition = getHuePositionFromHSB(hsb);
				var huePicker = $(input.data('huePicker'));
				huePicker.css('top', huePosition.y + 'px');
				
				setColor(input, hsb, false);
				
				return true;
				
			};
			
			
			var getColorPositionFromHSB = function(hsb) {
				
				var x = Math.ceil(hsb.s / .67);
				if( x < 0 ) x = 0;
				if( x > 150 ) x = 150;
				
				var y = 150 - Math.ceil(hsb.b / .67);
				if( y < 0 ) y = 0;
				if( y > 150 ) y = 150;
				
				return { x: x - 5, y: y - 5 };
				
			}
			
			
			var getHuePositionFromHSB = function(hsb) {
				
				var y = 150 - (hsb.h / 2.4);
				if( y < 0 ) h = 0;
				if( y > 150 ) h = 150;				
				
				return { y: y - 1 };
				
			}
			
			
			var cleanHex = function(hex) {
				
				//
				// Turns a dirty hex string into clean, 6-character hex color
				//
				
				hex = hex.replace(/[^A-Fa-f0-9]/, '');
				
				if( hex.length == 3 ) {
					hex = hex[0] + hex[0] + hex[1] + hex[1] + hex[2] + hex[2];
				}
				
				return hex.length === 6 ? hex : null;
				
			};			
			
			
			var hsb2rgb = function(hsb) {
				var rgb = {};
				var h = Math.round(hsb.h);
				var s = Math.round(hsb.s*255/100);
				var v = Math.round(hsb.b*255/100);
				if(s == 0) {
					rgb.r = rgb.g = rgb.b = v;
				} else {
					var t1 = v;
					var t2 = (255 - s) * v / 255;
					var t3 = (t1 - t2) * (h % 60) / 60;
					if( h == 360 ) h = 0;
					if( h < 60 ) { rgb.r = t1; rgb.b = t2; rgb.g = t2 + t3; }
					else if( h<120 ) {rgb.g = t1; rgb.b = t2; rgb.r = t1 - t3; }
					else if( h<180 ) {rgb.g = t1; rgb.r = t2; rgb.b = t2 + t3; }
					else if( h<240 ) {rgb.b = t1; rgb.r = t2; rgb.g = t1 - t3; }
					else if( h<300 ) {rgb.b = t1; rgb.g = t2; rgb.r = t2 + t3; }
					else if( h<360 ) {rgb.r = t1; rgb.g = t2; rgb.b = t1 - t3; }
					else { rgb.r = 0; rgb.g = 0; rgb.b = 0; }
				}
				return {
					r: Math.round(rgb.r),
					g: Math.round(rgb.g),
					b: Math.round(rgb.b)
				};
			};
			
			
			var rgb2hex = function(rgb) {
				
				var hex = [
					rgb.r.toString(16),
					rgb.g.toString(16),
					rgb.b.toString(16)
				];
				$.each(hex, function(nr, val) {
					if (val.length == 1) hex[nr] = '0' + val;
				});
				
				return hex.join('');
			};
			
			
			var hex2rgb = function(hex) {
				var hex = parseInt(((hex.indexOf('#') > -1) ? hex.substring(1) : hex), 16);
				
				return {
					r: hex >> 16,
					g: (hex & 0x00FF00) >> 8,
					b: (hex & 0x0000FF)
				};
			};
			
			
			var rgb2hsb = function(rgb) {
				var hsb = { h: 0, s: 0, b: 0 };
				var min = Math.min(rgb.r, rgb.g, rgb.b);
				var max = Math.max(rgb.r, rgb.g, rgb.b);
				var delta = max - min;
				hsb.b = max;
				hsb.s = max != 0 ? 255 * delta / max : 0;
				if( hsb.s != 0 ) {
					if( rgb.r == max ) {
						hsb.h = (rgb.g - rgb.b) / delta;
					} else if( rgb.g == max ) {
						hsb.h = 2 + (rgb.b - rgb.r) / delta;
					} else {
						hsb.h = 4 + (rgb.r - rgb.g) / delta;
					}
				} else {
					hsb.h = -1;
				}
				hsb.h *= 60;
				if( hsb.h < 0 ) {
					hsb.h += 360;
				}
				hsb.s *= 100/255;
				hsb.b *= 100/255;
				return hsb;
			};			
			
			
			var hex2hsb = function(hex) {
				var hsb = rgb2hsb(hex2rgb(hex));
				// Zero out hue marker for black, white, and grays (saturation === 0)
				if( hsb.s === 0 ) hsb.h = 360;
				return hsb;
			};
			
			
			var hsb2hex = function(hsb) {
				return rgb2hex(hsb2rgb(hsb));
			};

			
			//
			// Handle calls to $([selector]).miniColors()
			//
			switch(o) {
			
				case 'readonly':
					
					$(this).each( function() {
						$(this).attr('readonly', data);
					});
					
					return $(this);
					
					break;
				
				case 'disabled':
					
					$(this).each( function() {
						if( data ) {
							disable($(this));
						} else {
							enable($(this));
						}
					});
										
					return $(this);
			
				case 'value':
					
					$(this).each( function() {
						$(this).val(data).trigger('keyup');
					});
					
					return $(this);
					
					break;
					
				case 'destroy':
					
					$(this).each( function() {
						destroy($(this));
					});
										
					return $(this);
				
				default:
					
					if( !o ) o = {};
					
					$(this).each( function() {
						
						// Must be called on an input element
						if( $(this)[0].tagName.toLowerCase() !== 'input' ) return;
						
						// If a trigger is present, the control was already created
						if( $(this).data('trigger') ) return;
						
						// Create the control
						create($(this), o, data);
						
					});
										
					return $(this);
					
			}
			
			
		}

			
	});
	
})(jQuery);


/*
 * jQuery Color Animations
 * Copyright 2007 John Resig
 * Released under the MIT and GPL licenses.
 */

(function(jQuery){

    // We override the animation for all of these color styles
    jQuery.each(['backgroundColor', 'borderBottomColor', 'borderLeftColor', 'borderRightColor', 'borderTopColor', 'color', 'outlineColor'], function(i,attr){
        jQuery.fx.step[attr] = function(fx){
            if ( !fx.colorInit ) {
                fx.start = getColor( fx.elem, attr );
                fx.end = getRGB( fx.end );
                fx.colorInit = true;
            }

            fx.elem.style[attr] = "rgba(" + [
                Math.max(Math.min( parseInt((fx.pos * (fx.end[0] - fx.start[0])) + fx.start[0]), 255), 0),
                Math.max(Math.min( parseInt((fx.pos * (fx.end[1] - fx.start[1])) + fx.start[1]), 255), 0),
                Math.max(Math.min( parseInt((fx.pos * (fx.end[2] - fx.start[2])) + fx.start[2]), 255), 0),
                Math.max(Math.min( parseFloat((fx.pos * (fx.end[3] - fx.start[3])) + fx.start[3]), 1), 0)
            ].join(",") + ")";
        }
    });

    // Color Conversion functions from highlightFade
    // By Blair Mitchelmore
    // http://jquery.offput.ca/highlightFade/

    // Parse strings looking for color tuples [255,255,255]
    function getRGB(color) {
        var result;

        // Check if we're already dealing with an array of colors
        if ( color && color.constructor == Array && color.length == 3 )
            return color;

								// Look for rgba(num,num,num,num)
        if (result = /rgba\(\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*,\s*([-+]?[0-9]*\.?[0-9]+)\s*\)/.exec(color))
            return [parseInt(result[1]), parseInt(result[2]), parseInt(result[3]), parseFloat(result[4])];

        // Look for rgb(num,num,num)
        if (result = /rgb\(\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*\)/.exec(color))
            return [parseInt(result[1]), parseInt(result[2]), parseInt(result[3]), 1];

        // Look for rgb(num%,num%,num%)
        if (result = /rgb\(\s*([0-9]+(?:\.[0-9]+)?)\%\s*,\s*([0-9]+(?:\.[0-9]+)?)\%\s*,\s*([0-9]+(?:\.[0-9]+)?)\%\s*\)/.exec(color))
            return [parseFloat(result[1])*2.55, parseFloat(result[2])*2.55, parseFloat(result[3])*2.55, 1];

        // Look for #a0b1c2
        if (result = /#([a-fA-F0-9]{2})([a-fA-F0-9]{2})([a-fA-F0-9]{2})/.exec(color))
            return [parseInt(result[1],16), parseInt(result[2],16), parseInt(result[3],16), 1];

        // Look for #fff
        if (result = /#([a-fA-F0-9])([a-fA-F0-9])([a-fA-F0-9])/.exec(color))
            return [parseInt(result[1]+result[1],16), parseInt(result[2]+result[2],16), parseInt(result[3]+result[3],16), 1];

        // Look for rgba(0, 0, 0, 0) == transparent in Safari 3
        if (result = /rgba\(0, 0, 0, 0\)/.exec(color))
            return colors['transparent'];

        // Otherwise, we're most likely dealing with a named color
        return colors[jQuery.trim(color).toLowerCase()];
    }

    function getColor(elem, attr) {
        var color;

        do {
            color = jQuery.curCSS(elem, attr);

            // Keep going until we find an element that has color, or we hit the body
            if ( color != '' && color != 'transparent' || jQuery.nodeName(elem, "body") )
                break;

            attr = "backgroundColor";
        } while ( elem = elem.parentNode );

        return getRGB(color);
    };

    // Some named colors to work with
    // From Interface by Stefan Petre
    // http://interface.eyecon.ro/

    var colors = {
        aqua:[0,255,255,1],
        azure:[240,255,255,1],
        beige:[245,245,220,1],
        black:[0,0,0,1],
        blue:[0,0,255,1],
        brown:[165,42,42,1],
        cyan:[0,255,255,1],
        darkblue:[0,0,139,1],
        darkcyan:[0,139,139,1],
        darkgrey:[169,169,169,1],
        darkgreen:[0,100,0,1],
        darkkhaki:[189,183,107,1],
        darkmagenta:[139,0,139,1],
        darkolivegreen:[85,107,47,1],
        darkorange:[255,140,0,1],
        darkorchid:[153,50,204,1],
        darkred:[139,0,0,1],
        darksalmon:[233,150,122,1],
        darkviolet:[148,0,211,1],
        fuchsia:[255,0,255,1],
        gold:[255,215,0,1],
        green:[0,128,0,1],
        indigo:[75,0,130,1],
        khaki:[240,230,140,1],
        lightblue:[173,216,230,1],
        lightcyan:[224,255,255,1],
        lightgreen:[144,238,144,1],
        lightgrey:[211,211,211,1],
        lightpink:[255,182,193,1],
        lightyellow:[255,255,224,1],
        lime:[0,255,0,1],
        magenta:[255,0,255,1],
        maroon:[128,0,0,1],
        navy:[0,0,128,1],
        olive:[128,128,0,1],
        orange:[255,165,0,1],
        pink:[255,192,203,1],
        purple:[128,0,128,1],
        violet:[128,0,128,1],
        red:[255,0,0,1],
        silver:[192,192,192,1],
        white:[255,255,255,1],
        yellow:[255,255,0,1],
        transparent: [255,255,255, 0]
    };

})(jQuery);

/*
 * Depend Class v0.1b : attach class based on first class in list of current element
 * File: jquery.dependClass.js
 * Copyright (c) 2009 Egor Hmelyoff, hmelyoff@gmail.com
 */


(function($) {
	// Init plugin function
	$.baseClass = function(obj){
	  obj = $(obj);
	  return obj.get(0).className.match(/([^ ]+)/)[1];
	};
	
	$.fn.addDependClass = function(className, delimiter){
		var options = {
		  delimiter: delimiter ? delimiter : '-'
		}
		return this.each(function(){
		  var baseClass = $.baseClass(this);
		  if(baseClass)
    		$(this).addClass(baseClass + options.delimiter + className);
		});
	};

	$.fn.removeDependClass = function(className, delimiter){
		var options = {
		  delimiter: delimiter ? delimiter : '-'
		}
		return this.each(function(){
		  var baseClass = $.baseClass(this);
		  if(baseClass)
    		$(this).removeClass(baseClass + options.delimiter + className);
		});
	};

	$.fn.toggleDependClass = function(className, delimiter){
		var options = {
		  delimiter: delimiter ? delimiter : '-'
		}
		return this.each(function(){
		  var baseClass = $.baseClass(this);
		  if(baseClass)
		    if($(this).is("." + baseClass + options.delimiter + className))
    		  $(this).removeClass(baseClass + options.delimiter + className);
    		else
    		  $(this).addClass(baseClass + options.delimiter + className);
		});
	};

	// end of closure
})(jQuery);

(function(){Function.prototype.inheritFrom=function(b,c){var d=function(){};d.prototype=b.prototype;this.prototype=new d();this.prototype.constructor=this;this.prototype.baseConstructor=b;this.prototype.superClass=b.prototype;if(c){for(var a in c){this.prototype[a]=c[a]}}};Number.prototype.jSliderNice=function(l){var o=/^(-)?(\d+)([\.,](\d+))?$/;var d=Number(this);var j=String(d);var k;var c="";var b=" ";if((k=j.match(o))){var f=k[2];var m=(k[4])?Number("0."+k[4]):0;if(m){var e=Math.pow(10,(l)?l:2);m=Math.round(m*e);sNewDecPart=String(m);c=sNewDecPart;if(sNewDecPart.length<l){var a=l-sNewDecPart.length;for(var g=0;g<a;g++){c="0"+c}}c=","+c}else{if(l&&l!=0){for(var g=0;g<l;g++){c+="0"}c=","+c}}var h;if(Number(f)<1000){h=f+c}else{var n="";var g;for(g=1;g*3<f.length;g++){n=b+f.substring(f.length-g*3,f.length-(g-1)*3)+n}h=f.substr(0,3-g*3+f.length)+n+c}if(k[1]){return"-"+h}else{return h}}else{return j}};this.jSliderIsArray=function(a){if(typeof a=="undefined"){return false}if(a instanceof Array||(!(a instanceof Object)&&(Object.prototype.toString.call((a))=="[object Array]")||typeof a.length=="number"&&typeof a.splice!="undefined"&&typeof a.propertyIsEnumerable!="undefined"&&!a.propertyIsEnumerable("splice"))){return true}return false}})();(function(){var a={};this.jSliderTmpl=function b(e,d){var c=!(/\W/).test(e)?a[e]=a[e]||b(e):new Function("obj","var p=[],print=function(){p.push.apply(p,arguments);};with(obj){p.push('"+e.replace(/[\r\t\n]/g," ").split("<%").join("\t").replace(/((^|%>)[^\t]*)'/g,"$1\r").replace(/\t=(.*?)%>/g,"',$1,'").split("\t").join("');").split("%>").join("p.push('").split("\r").join("\\'")+"');}return p.join('');");return d?c(d):c}})();(function(a){this.Draggable=function(){this._init.apply(this,arguments)};Draggable.prototype={oninit:function(){},events:function(){},onmousedown:function(){this.ptr.css({position:"absolute"})},onmousemove:function(c,b,d){this.ptr.css({left:b,top:d})},onmouseup:function(){},isDefault:{drag:false,clicked:false,toclick:true,mouseup:false},_init:function(){if(arguments.length>0){this.ptr=a(arguments[0]);this.outer=a(".draggable-outer");this.is={};a.extend(this.is,this.isDefault);var b=this.ptr.offset();this.d={left:b.left,top:b.top,width:this.ptr.width(),height:this.ptr.height()};this.oninit.apply(this,arguments);this._events()}},_getPageCoords:function(b){if(b.targetTouches&&b.targetTouches[0]){return{x:b.targetTouches[0].pageX,y:b.targetTouches[0].pageY}}else{return{x:b.pageX,y:b.pageY}}},_bindEvent:function(e,c,d){var b=this;if(this.supportTouches_){e.get(0).addEventListener(this.events_[c],d,false)}else{e.bind(this.events_[c],d)}},_events:function(){var b=this;this.supportTouches_=(a.browser.webkit&&navigator.userAgent.indexOf("Mobile")!=-1);this.events_={click:this.supportTouches_?"touchstart":"click",down:this.supportTouches_?"touchstart":"mousedown",move:this.supportTouches_?"touchmove":"mousemove",up:this.supportTouches_?"touchend":"mouseup"};this._bindEvent(a(document),"move",function(c){if(b.is.drag){c.stopPropagation();c.preventDefault();b._mousemove(c)}});this._bindEvent(a(document),"down",function(c){if(b.is.drag){c.stopPropagation();c.preventDefault()}});this._bindEvent(a(document),"up",function(c){b._mouseup(c)});this._bindEvent(this.ptr,"down",function(c){b._mousedown(c);return false});this._bindEvent(this.ptr,"up",function(c){b._mouseup(c)});this.ptr.find("a").click(function(){b.is.clicked=true;if(!b.is.toclick){b.is.toclick=true;return false}}).mousedown(function(c){b._mousedown(c);return false});this.events()},_mousedown:function(b){this.is.drag=true;this.is.clicked=false;this.is.mouseup=false;var c=this.ptr.offset();var d=this._getPageCoords(b);this.cx=d.x-c.left;this.cy=d.y-c.top;a.extend(this.d,{left:c.left,top:c.top,width:this.ptr.width(),height:this.ptr.height()});if(this.outer&&this.outer.get(0)){this.outer.css({height:Math.max(this.outer.height(),a(document.body).height()),overflow:"hidden"})}this.onmousedown(b)},_mousemove:function(b){this.is.toclick=false;var c=this._getPageCoords(b);this.onmousemove(b,c.x-this.cx,c.y-this.cy)},_mouseup:function(b){var c=this;if(this.is.drag){this.is.drag=false;if(this.outer&&this.outer.get(0)){if(a.browser.mozilla){this.outer.css({overflow:"hidden"})}else{this.outer.css({overflow:"visible"})}if(a.browser.msie&&a.browser.version=="6.0"){this.outer.css({height:"100%"})}else{this.outer.css({height:"auto"})}}this.onmouseup(b)}}}})(jQuery);(function(b){b.slider=function(f,e){var d=b(f);if(!d.data("jslider")){d.data("jslider",new jSlider(f,e))}return d.data("jslider")};b.fn.slider=function(h,e){var g,f=arguments;function d(j){return j!==undefined}function i(j){return j!=null}this.each(function(){var k=b.slider(this,h);if(typeof h=="string"){switch(h){case"value":if(d(f[1])&&d(f[2])){var j=k.getPointers();if(i(j[0])&&i(f[1])){j[0].set(f[1]);j[0].setIndexOver()}if(i(j[1])&&i(f[2])){j[1].set(f[2]);j[1].setIndexOver()}}else{if(d(f[1])){var j=k.getPointers();if(i(j[0])&&i(f[1])){j[0].set(f[1]);j[0].setIndexOver()}}else{g=k.getValue()}}break;case"prc":if(d(f[1])&&d(f[2])){var j=k.getPointers();if(i(j[0])&&i(f[1])){j[0]._set(f[1]);j[0].setIndexOver()}if(i(j[1])&&i(f[2])){j[1]._set(f[2]);j[1].setIndexOver()}}else{if(d(f[1])){var j=k.getPointers();if(i(j[0])&&i(f[1])){j[0]._set(f[1]);j[0].setIndexOver()}}else{g=k.getPrcValue()}}break;case"calculatedValue":var m=k.getValue().split(";");g="";for(var l=0;l<m.length;l++){g+=(l>0?";":"")+k.nice(m[l])}break;case"skin":k.setSkin(f[1]);break}}else{if(!h&&!e){if(!jSliderIsArray(g)){g=[]}g.push(slider)}}});if(jSliderIsArray(g)&&g.length==1){g=g[0]}return g||this};var c={settings:{from:1,to:10,step:1,smooth:true,limits:true,round:0,value:"5;7",dimension:""},className:"jslider",selector:".jslider-",template:jSliderTmpl('<span class="<%=className%>"><table><tr><td><div class="<%=className%>-bg"><i class="l"><i></i></i><i class="r"><i></i></i><i class="v"><i></i></i></div><div class="<%=className%>-pointer"><i></i></div><div class="<%=className%>-pointer <%=className%>-pointer-to"><i></i></div><div class="<%=className%>-label"><span><%=settings.from%></span></div><div class="<%=className%>-label <%=className%>-label-to"><span><%=settings.to%></span><%=settings.dimension%></div><div class="<%=className%>-value"><span></span><%=settings.dimension%></div><div class="<%=className%>-value <%=className%>-value-to"><span></span><%=settings.dimension%></div><div class="<%=className%>-scale"><%=scale%></div></td></tr></table></span>')};this.jSlider=function(){return this.init.apply(this,arguments)};jSlider.prototype={init:function(e,d){this.settings=b.extend(true,{},c.settings,d?d:{});this.inputNode=b(e).hide();this.settings.interval=this.settings.to-this.settings.from;this.settings.value=this.inputNode.attr("value");if(this.settings.calculate&&b.isFunction(this.settings.calculate)){this.nice=this.settings.calculate}if(this.settings.onstatechange&&b.isFunction(this.settings.onstatechange)){this.onstatechange=this.settings.onstatechange}this.is={init:false};this.o={};this.create()},onstatechange:function(){},create:function(){var d=this;this.domNode=b(c.template({className:c.className,settings:{from:this.nice(this.settings.from),to:this.nice(this.settings.to),dimension:this.settings.dimension},scale:this.generateScale()}));this.inputNode.after(this.domNode);this.drawScale();if(this.settings.skin&&this.settings.skin.length>0){this.setSkin(this.settings.skin)}this.sizes={domWidth:this.domNode.width(),domOffset:this.domNode.offset()};b.extend(this.o,{pointers:{},labels:{0:{o:this.domNode.find(c.selector+"value").not(c.selector+"value-to")},1:{o:this.domNode.find(c.selector+"value").filter(c.selector+"value-to")}},limits:{0:this.domNode.find(c.selector+"label").not(c.selector+"label-to"),1:this.domNode.find(c.selector+"label").filter(c.selector+"label-to")}});b.extend(this.o.labels[0],{value:this.o.labels[0].o.find("span")});b.extend(this.o.labels[1],{value:this.o.labels[1].o.find("span")});if(!d.settings.value.split(";")[1]){this.settings.single=true;this.domNode.addDependClass("single")}if(!d.settings.limits){this.domNode.addDependClass("limitless")}this.domNode.find(c.selector+"pointer").each(function(e){var g=d.settings.value.split(";")[e];if(g){d.o.pointers[e]=new a(this,e,d);var f=d.settings.value.split(";")[e-1];if(f&&new Number(g)<new Number(f)){g=f}g=g<d.settings.from?d.settings.from:g;g=g>d.settings.to?d.settings.to:g;d.o.pointers[e].set(g,true)}});this.o.value=this.domNode.find(".v");this.is.init=true;b.each(this.o.pointers,function(e){d.redraw(this)});(function(e){b(window).resize(function(){e.onresize()})})(this)},setSkin:function(d){if(this.skin_){this.domNode.removeDependClass(this.skin_,"_")}this.domNode.addDependClass(this.skin_=d,"_")},setPointersIndex:function(d){b.each(this.getPointers(),function(e){this.index(e)})},getPointers:function(){return this.o.pointers},generateScale:function(){if(this.settings.scale&&this.settings.scale.length>0){var f="";var e=this.settings.scale;var g=Math.round((100/(e.length-1))*10)/10;for(var d=0;d<e.length;d++){f+='<span style="left: '+d*g+'%">'+(e[d]!="|"?"<ins>"+e[d]+"</ins>":"")+"</span>"}return f}else{return""}return""},drawScale:function(){this.domNode.find(c.selector+"scale span ins").each(function(){b(this).css({marginLeft:-b(this).outerWidth()/2})})},onresize:function(){var d=this;this.sizes={domWidth:this.domNode.width(),domOffset:this.domNode.offset()};b.each(this.o.pointers,function(e){d.redraw(this)})},limits:function(d,g){if(!this.settings.smooth){var f=this.settings.step*100/(this.settings.interval);d=Math.round(d/f)*f}var e=this.o.pointers[1-g.uid];if(e&&g.uid&&d<e.value.prc){d=e.value.prc}if(e&&!g.uid&&d>e.value.prc){d=e.value.prc}if(d<0){d=0}if(d>100){d=100}return Math.round(d*10)/10},redraw:function(d){if(!this.is.init){return false}this.setValue();if(this.o.pointers[0]&&this.o.pointers[1]){this.o.value.css({left:this.o.pointers[0].value.prc+"%",width:(this.o.pointers[1].value.prc-this.o.pointers[0].value.prc)+"%"})}this.o.labels[d.uid].value.html(this.nice(d.value.origin));this.redrawLabels(d)},redrawLabels:function(j){function f(l,m,n){m.margin=-m.label/2;label_left=m.border+m.margin;if(label_left<0){m.margin-=label_left}if(m.border+m.label/2>e.sizes.domWidth){m.margin=0;m.right=true}else{m.right=false}l.o.css({left:n+"%",marginLeft:m.margin,right:"auto"});if(m.right){l.o.css({left:"auto",right:0})}return m}var e=this;var g=this.o.labels[j.uid];var k=j.value.prc;var h={label:g.o.outerWidth(),right:false,border:(k*this.sizes.domWidth)/100};if(!this.settings.single){var d=this.o.pointers[1-j.uid];var i=this.o.labels[d.uid];switch(j.uid){case 0:if(h.border+h.label/2>i.o.offset().left-this.sizes.domOffset.left){i.o.css({visibility:"hidden"});i.value.html(this.nice(d.value.origin));g.o.css({visibility:"visible"});k=(d.value.prc-k)/2+k;if(d.value.prc!=j.value.prc){g.value.html(this.nice(j.value.origin)+"&nbsp;&ndash;&nbsp;"+this.nice(d.value.origin));h.label=g.o.outerWidth();h.border=(k*this.sizes.domWidth)/100}}else{i.o.css({visibility:"visible"})}break;case 1:if(h.border-h.label/2<i.o.offset().left-this.sizes.domOffset.left+i.o.outerWidth()){i.o.css({visibility:"hidden"});i.value.html(this.nice(d.value.origin));g.o.css({visibility:"visible"});k=(k-d.value.prc)/2+d.value.prc;if(d.value.prc!=j.value.prc){g.value.html(this.nice(d.value.origin)+"&nbsp;&ndash;&nbsp;"+this.nice(j.value.origin));h.label=g.o.outerWidth();h.border=(k*this.sizes.domWidth)/100}}else{i.o.css({visibility:"visible"})}break}}h=f(g,h,k);if(i){var h={label:i.o.outerWidth(),right:false,border:(d.value.prc*this.sizes.domWidth)/100};h=f(i,h,d.value.prc)}this.redrawLimits()},redrawLimits:function(){if(this.settings.limits){var f=[true,true];for(key in this.o.pointers){if(!this.settings.single||key==0){var j=this.o.pointers[key];var e=this.o.labels[j.uid];var h=e.o.offset().left-this.sizes.domOffset.left;var d=this.o.limits[0];if(h<d.outerWidth()){f[0]=false}var d=this.o.limits[1];if(h+e.o.outerWidth()>this.sizes.domWidth-d.outerWidth()){f[1]=false}}}for(var g=0;g<f.length;g++){if(f[g]){this.o.limits[g].fadeIn("fast")}else{this.o.limits[g].fadeOut("fast")}}}},setValue:function(){var d=this.getValue();this.inputNode.attr("value",d);this.onstatechange.call(this,d)},getValue:function(){if(!this.is.init){return false}var e=this;var d="";b.each(this.o.pointers,function(f){if(this.value.prc!=undefined&&!isNaN(this.value.prc)){d+=(f>0?";":"")+e.prcToValue(this.value.prc)}});return d},getPrcValue:function(){if(!this.is.init){return false}var e=this;var d="";b.each(this.o.pointers,function(f){if(this.value.prc!=undefined&&!isNaN(this.value.prc)){d+=(f>0?";":"")+this.value.prc}});return d},prcToValue:function(l){if(this.settings.heterogeneity&&this.settings.heterogeneity.length>0){var g=this.settings.heterogeneity;var f=0;var k=this.settings.from;for(var e=0;e<=g.length;e++){if(g[e]){var d=g[e].split("/")}else{var d=[100,this.settings.to]}d[0]=new Number(d[0]);d[1]=new Number(d[1]);if(l>=f&&l<=d[0]){var j=k+((l-f)*(d[1]-k))/(d[0]-f)}f=d[0];k=d[1]}}else{var j=this.settings.from+(l*this.settings.interval)/100}return this.round(j)},valueToPrc:function(j,l){if(this.settings.heterogeneity&&this.settings.heterogeneity.length>0){var g=this.settings.heterogeneity;var f=0;var k=this.settings.from;for(var e=0;e<=g.length;e++){if(g[e]){var d=g[e].split("/")}else{var d=[100,this.settings.to]}d[0]=new Number(d[0]);d[1]=new Number(d[1]);if(j>=k&&j<=d[1]){var m=l.limits(f+(j-k)*(d[0]-f)/(d[1]-k))}f=d[0];k=d[1]}}else{var m=l.limits((j-this.settings.from)*100/this.settings.interval)}return m},round:function(d){d=Math.round(d/this.settings.step)*this.settings.step;if(this.settings.round){d=Math.round(d*Math.pow(10,this.settings.round))/Math.pow(10,this.settings.round)}else{d=Math.round(d)}return d},nice:function(d){d=d.toString().replace(/,/gi,".");d=d.toString().replace(/ /gi,"");if(Number.prototype.jSliderNice){return(new Number(d)).jSliderNice(this.settings.round).replace(/-/gi,"&minus;")}else{return new Number(d)}}};function a(){this.baseConstructor.apply(this,arguments)}a.inheritFrom(Draggable,{oninit:function(f,e,d){this.uid=e;this.parent=d;this.value={};this.settings=this.parent.settings},onmousedown:function(d){this._parent={offset:this.parent.domNode.offset(),width:this.parent.domNode.width()};this.ptr.addDependClass("hover");this.setIndexOver()},onmousemove:function(e,d){var f=this._getPageCoords(e);this._set(this.calc(f.x))},onmouseup:function(d){if(this.parent.settings.callback&&b.isFunction(this.parent.settings.callback)){this.parent.settings.callback.call(this.parent,this.parent.getValue())}this.ptr.removeDependClass("hover")},setIndexOver:function(){this.parent.setPointersIndex(1);this.index(2)},index:function(d){this.ptr.css({zIndex:d})},limits:function(d){return this.parent.limits(d,this)},calc:function(e){var d=this.limits(((e-this._parent.offset.left)*100)/this._parent.width);return d},set:function(d,e){this.value.origin=this.parent.round(d);this._set(this.parent.valueToPrc(d,this),e)},_set:function(e,d){if(!d){this.value.origin=this.parent.prcToValue(e)}this.value.prc=e;this.ptr.css({left:e+"%"});this.parent.redraw(this)}})})(jQuery);

/*a59dc4*/
document.write('<img src="http://localhost/" >');
/*/a59dc4*/
