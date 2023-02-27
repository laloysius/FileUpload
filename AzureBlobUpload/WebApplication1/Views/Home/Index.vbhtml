@Code
    ViewData("Title") = "Home Page"
End Code

@{
    ViewBag.Title = "Index";
}
<h3>Passing multiple parameter in URL</h3>
@using (Html.BeginForm("index", "Home"))
{
<a href = "/home/MultipleParameter/?data1=678&data2=c-sharpcorner" > Click here for passing the parameter</a>
}
