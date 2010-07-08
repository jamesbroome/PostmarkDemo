<%@ PAGE language="C#" masterpagefile="~/Views/Shared/Site.Master" inherits="System.Web.Mvc.ViewPage" %>

<ASP:CONTENT id="Content1" contentplaceholderid="TitleContent" runat="server">
    Postmark ASP.NET MVC Demo
</ASP:CONTENT>
<ASP:CONTENT id="Content2" contentplaceholderid="MainContent" runat="server">
    <div class="post">
        <h2 class="post-title">
            <a href="http://developer.postmarkapp.com/#before-you-get-started"
                target="_blank"
                title="Before you get started">Before you get started</a></h2>
        <p>
           You'll need to create an account with <a href="http://postmarkapp.com/" target="_blank">Postmark</a>, and set up a server and sender signature.
           This is really easy, and takes about 5 minutes. 
        </p>
        <p>
            Once your server is set up, you'll need to set the API key and From address in the web.config file.
        </p>
        <p>
            That's it - enter an email address in the box below and hit the button!
        </p>
        <h2>
            <%= TempData["Message"] %></h2>
    </div>
    <div id="respond">
        <form method="post" action="/">
        <p>
            <label for="email">Email address<small>(required)</small></label>
            <input type="text" name="email" id="email" value="" size="22" tabindex="2" aria-required='true' />
            <input name="submit" type="submit" id="submit" tabindex="5" value="Send me an email" /></p>
        </form>
    </div>
    <div class="post">
        <p>
            This demo application is built using <a href="http://www.asp.net/mvc/" target="_blank">ASP.NET MVC 2</a>, and the <a href="http://github.com/lunarbits/postmark-dotnet" target="_blank">Postmark .Net API</a>.<br />
            Dependency injection is done using <a href="http://ninject.org/" target="_blank">Ninject</a><br />
            Stylesheet is taken from the <a href="http://www.ndesign-studio.com/wp-themes/notepad" target="_blank">Notepad Wordpress theme by n.design studio</a>
        </p>
    </div>
</ASP:CONTENT>
