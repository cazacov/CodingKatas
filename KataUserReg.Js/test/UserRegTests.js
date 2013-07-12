module("username validation");

test("Validation of empty user names marks it as missing", function()
{
    $("#name").val("");
    $("#register").click();
    ok(uiHelper.isMarkedAsMissing("#name"));
})

