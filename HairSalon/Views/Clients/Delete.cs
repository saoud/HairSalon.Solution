@{
  Layout = "_Layout";
}

@model HairSalon.Models.Client

<h2>Are you sure you want to delete this?</h2>

@Html.DisplayNameFor(model => model.Name): @Html.DisplayFor(model => model.Name)
@using (Html.BeginForm())
{
  <input type="submit" value="Delete" />
}
@Html.ActionLink("Back to List", "Index")