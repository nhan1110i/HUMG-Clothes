$(document).ready(function () {
    $("#cbCheckAll").click(function () {
        $('input:checkbox').not(this).prop('checked', this.checked);
    });
});