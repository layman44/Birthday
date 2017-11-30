(function ($) {

    $(function () {

        $('input[name=Birthday_Lunar]').datepicker({
            language: "zh-CN",
            autoclose: true,
            clearBtn: true,
            orientation: "bottom auto",
            format: "yyyy-mm-dd"
        }).on("changeDate", function (e) {
            var solardate = calendar.lunar2solar(e.date.getFullYear(), e.date.getMonth()+1, e.date.getDate());
            $('input[name=Birthday_Solar]').datepicker('update', new Date(solardate.cYear, solardate.cMonth-1, solardate.cDay));
        });

        $('input[name=Birthday_Solar]').datepicker({
            language: "zh-CN",
            autoclose: true,
            clearBtn: true,
            orientation: "bottom auto",
            format: "yyyy-mm-dd"
        }).on("changeDate", function (e) {
            var lunardate = calendar.solar2lunar(e.date.getFullYear(), e.date.getMonth()+1, e.date.getDate());
            $('input[name=Birthday_Lunar]').datepicker('update', new Date(lunardate.lYear, lunardate.lMonth-1, lunardate.lDay));
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