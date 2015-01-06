(function() {
	'use strict';
	var $asm = {};
	global.ReactJs = global.ReactJs || {};
	ss.initAssembly($asm, 'saltarelle-react');
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.IReactElement
	var $ReactJs_IReactElement = function() {
	};
	$ReactJs_IReactElement.__typeName = 'ReactJs.IReactElement';
	global.ReactJs.IReactElement = $ReactJs_IReactElement;
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.ObjectExtensionMethods
	var $ReactJs_ObjectExtensionMethods = function() {
	};
	$ReactJs_ObjectExtensionMethods.__typeName = 'ReactJs.ObjectExtensionMethods';
	global.ReactJs.ObjectExtensionMethods = $ReactJs_ObjectExtensionMethods;
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.Props
	var $ReactJs_Props = function() {
	};
	$ReactJs_Props.__typeName = 'ReactJs.Props';
	$ReactJs_Props.createInstance = function() {
		return {};
	};
	global.ReactJs.Props = $ReactJs_Props;
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.PropsExtensions
	var $ReactJs_PropsExtensions = function() {
	};
	$ReactJs_PropsExtensions.__typeName = 'ReactJs.PropsExtensions';
	$ReactJs_PropsExtensions.onCopy = function(props, callback) {
		props.onCopy = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onCut = function(props, callback) {
		props.onCut = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onPaste = function(props, callback) {
		props.onPaste = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onKeyDown = function(props, callback) {
		props.onKeyDown = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onKeyPress = function(props, callback) {
		props.onKeyPress = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onKeyUp = function(props, callback) {
		props.onKeyUp = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onFocus = function(props, callback) {
		props.onFocus = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onBlur = function(props, callback) {
		props.onBlur = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onChange = function(props, callback) {
		props.onChange = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onInput = function(props, callback) {
		props.onInput = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onSubmit = function(props, callback) {
		props.onSubmit = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onClick = function(props, callback) {
		props.onClick = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDoubleClick = function(props, callback) {
		props.onDoubleClick = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDrag = function(props, callback) {
		props.onDrag = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDragEnd = function(props, callback) {
		props.onDragEnd = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDragEnter = function(props, callback) {
		props.onDragEnter = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDragExit = function(props, callback) {
		props.onDragExit = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDragLeave = function(props, callback) {
		props.onDragLeave = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDragOver = function(props, callback) {
		props.onDragOver = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDragStart = function(props, callback) {
		props.onDragStart = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onDrop = function(props, callback) {
		props.onDrop = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onMouseDown = function(props, callback) {
		props.onMouseDown = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onMouseEnter = function(props, callback) {
		props.onMouseEnter = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onMouseLeave = function(props, callback) {
		props.onMouseLeave = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onMouseMove = function(props, callback) {
		props.onMouseMove = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onMouseOut = function(props, callback) {
		props.onMouseOut = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onMouseOver = function(props, callback) {
		props.onMouseOver = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onMouseUp = function(props, callback) {
		props.onMouseUp = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onTouchCancel = function(props, callback) {
		props.onTouchCancel = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onTouchEnd = function(props, callback) {
		props.onTouchEnd = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onTouchMove = function(props, callback) {
		props.onTouchMove = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onTouchStart = function(props, callback) {
		props.onTouchStart = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onScroll = function(props, callback) {
		props.onScroll = callback;
		return props;
	};
	$ReactJs_PropsExtensions.onWheel = function(props, callback) {
		props.onWheel = callback;
		return props;
	};
	global.ReactJs.PropsExtensions = $ReactJs_PropsExtensions;
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.ReactComponent
	var $ReactJs_ReactComponent = function() {
	};
	$ReactJs_ReactComponent.__typeName = 'ReactJs.ReactComponent';
	global.ReactJs.ReactComponent = $ReactJs_ReactComponent;
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.ReactElement
	var $ReactJs_ReactElement = function() {
	};
	$ReactJs_ReactElement.__typeName = 'ReactJs.ReactElement';
	global.ReactJs.ReactElement = $ReactJs_ReactElement;
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.ReactHelper
	var $ReactJs_ReactHelper = function() {
	};
	$ReactJs_ReactHelper.__typeName = 'ReactJs.ReactHelper';
	$ReactJs_ReactHelper.CreateComponent = function(T) {
		return function() {
			var type = T;
			var body = 'var $ob = {}; var $type=' + ss.getTypeFullName(type) + ';';
			var methods = $ReactJs_TypeExtensionMethods.GetInstanceMethodNames(type);
			var getInitialState = 'getInitialState';
			if (!ss.contains(methods, getInitialState)) {
				// if user did not specify a getInitialState, provide an empty one
				body += ss.formatString('$ob.{0}=(function() {{ /*$type.apply(this);*/ return {{ }}; }});', getInitialState);
			}
			else {
				body += ss.formatString('$ob.{0}=(function() {{ /*$type.apply(this);*/ return $type.prototype.{0}(); }});', getInitialState);
			}
			// TODO .apply needed? 
			ss.remove(methods, getInitialState);
			for (var $t1 = 0; $t1 < methods.length; $t1++) {
				var method = methods[$t1];
				body += ss.formatString('$ob.{0}=$type.prototype.{0};', method);
			}
			body += 'return $ob;';
			// TODO statics
			// TODO field and properties
			var F = new Function('', body);
			var defob = F.call(null);
			var component = React.createClass(defob);
			// writes in _factory
			type._factory = component;
			return component;
		};
	};
	global.ReactJs.ReactHelper = $ReactJs_ReactHelper;
	////////////////////////////////////////////////////////////////////////////////
	// ReactJs.TypeExtensionMethods
	var $ReactJs_TypeExtensionMethods = function() {
	};
	$ReactJs_TypeExtensionMethods.__typeName = 'ReactJs.TypeExtensionMethods';
	$ReactJs_TypeExtensionMethods.GetInstanceMethodNames = function(type) {
		var result = [];
		var $t1 = ss.getEnumerator(Object.keys(type.prototype));
		try {
			while ($t1.moveNext()) {
				var key = $t1.current();
				if (key !== 'constructor') {
					result.push(key);
				}
			}
		}
		finally {
			$t1.dispose();
		}
		return result;
	};
	global.ReactJs.TypeExtensionMethods = $ReactJs_TypeExtensionMethods;
	ss.initInterface($ReactJs_IReactElement, $asm, { getInitialState: null, getDefaultProps: null, render: null, componentWillMount: null, componentDidMount: null, componentWillReceiveProps: null, shouldComponentUpdate: null, componentWillUpdate: null, componentDidUpdate: null, componentWillUnmount: null });
	ss.initClass($ReactJs_ObjectExtensionMethods, $asm, {});
	ss.initClass($ReactJs_Props, $asm, {});
	ss.initClass($ReactJs_PropsExtensions, $asm, {});
	ss.initClass($ReactJs_ReactComponent, $asm, {});
	ss.initClass($ReactJs_ReactElement, $asm, {});
	ss.initClass($ReactJs_ReactHelper, $asm, {});
	ss.initClass($ReactJs_TypeExtensionMethods, $asm, {});
})();
