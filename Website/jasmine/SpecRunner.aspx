<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html>
<html>
<head>
  <title>Jasmine Spec Runner</title>
  <meta http-equiv="cache-control" content="no-cache" />
  <link rel="shortcut icon" type="image/png" href="lib/jasmine-1.3.1/jasmine_favicon.png">
  <link rel="stylesheet" type="text/css" href="lib/jasmine-1.3.1/jasmine.css">
  <script type="text/javascript" src="lib/jasmine-1.3.1/jasmine.js"></script>
  <script type="text/javascript" src="lib/jasmine-1.3.1/jasmine-html.js"></script>

  <!-- include source files here... -->  
   <%=this.NoCacheJavaScript("~libs/angular.js")%>
   <%=this.NoCacheJavaScript("~libs/i18n/angular-locale_it.js")%>
   <%=this.NoCacheJavaScript("~libs/angular-ui-router.js")%>
   <%=this.NoCacheJavaScript("~libs/ui-bootstrap-tpls-0.10.0.js")%>

   <%=this.NoCacheJavaScript("~libs/mscorlib.js")%>
   <%=this.NoCacheJavaScript("~libs/Saltarelle.AngularJS.js")%>

   <%=this.NoCacheJavaScript("~scripts/App.js")%>

   <script type="text/javascript">
      new JasmineTests().SpecRunner(); // run tests contained in the class JasmineTests, SpecRunner() method
   </script>

  <script type="text/javascript">
    (function() {
      var jasmineEnv = jasmine.getEnv();
      jasmineEnv.updateInterval = 1000;

      var htmlReporter = new jasmine.HtmlReporter();

      jasmineEnv.addReporter(htmlReporter);

      jasmineEnv.specFilter = function(spec) {
        return htmlReporter.specFilter(spec);
      };

      var currentWindowOnload = window.onload;

      window.onload = function() {
        if (currentWindowOnload) {
          currentWindowOnload();
        }
        execJasmine();
      };

      function execJasmine() {
        jasmineEnv.execute();
      }

    })();
  </script>

</head>

<body>
</body>
</html>
