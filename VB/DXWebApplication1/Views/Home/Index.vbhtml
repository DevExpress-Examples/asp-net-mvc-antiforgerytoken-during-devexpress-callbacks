<script type="text/javascript">
    function OnBeginCallback(s, e) {
        var container = $("body");
        var token = $('input[name="__RequestVerificationToken"]', container).val();
        e.customArgs["__RequestVerificationToken"] = token;
    }
</script>

@Html.Partial("CallbackPanelPartial")
<input type="button" value="Perform Callback" onclick="cp.PerformCallback();" />