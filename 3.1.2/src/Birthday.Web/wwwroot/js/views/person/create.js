(function ($) {

    $(function () {

        $('input[name=Birthday_Lunar]').datepicker({
            language: "zh-CN",
            autoclose: true,
            clearBtn: true,
            orientation: "bottom auto",
            format: "yyyy-mm-dd"
        }).on("changeDate", function (e) {
            
        });

        $('input[name=Birthday_Solar]').datepicker({
            language: "zh-CN",
            autoclose: true,
            clearBtn: true,
            orientation: "bottom auto",
            format: "yyyy-mm-dd"
        });
        var _$form = $('#PersonCreationForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var input = _$form.serializeFormToObject();
                abp.services.app.personService.create(input)
                    .done(function () {
                        location.href = '/Birthday';
                    });
            });
    });

})(jQuery);