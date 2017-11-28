(function ($) {

    $(function () {

        $('input[name=Birthday_Lunar]').datepicker({
        });

        $('input[name=Birthday_Solar]').datepicker({
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