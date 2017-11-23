(function ($) {

    $(function () {
        var modifybtn = $('#btnmodify');
        modifybtn.click(function (e) {
            e.preventDefault();
        });

        var deletebtn = $('a[name=deletebtn]');
        deletebtn.click(function (e) {
            e.preventDefault();
            var id = $(this).attr("data-person-id");
            var name = $(this).attr("data-person-name");
            abp.message.confirm(
                "删除[" + name + "]?",
                function (isConfirmed) {
                    if (isConfirmed) {
                        abp.services.app.personService.delete(id).done(function () {
                            location.reload(true);
                        });
                    }
                }
            );
        });

    });

})(jQuery);