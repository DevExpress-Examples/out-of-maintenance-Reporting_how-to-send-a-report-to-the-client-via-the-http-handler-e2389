# How to send a report to the client via the HTTP handler


<p>This example demonstrates how to send a report to the client's browser via the ASP.NET HTTP handler (<a href="http://msdn.microsoft.com/en-us/library/system.web.ihttphandler.aspx">IHttpHandler Interface</a>). Certainly, you can do the same thing at the web page level (like in the <a href="https://www.devexpress.com/Support/Center/p/E1281">How to programmatically export a report in an ASP.NET application</a> example). But, actually, the exporting does not require the control tree or the whole web form. Moreover, generic handlers are faster than ASPX web forms that do exactly the same operations — even without server controls. So, it makes sense to use the HTTP handler for this purpose. This will result in greater performance and much simpler code to debug.</p>

<br/>


