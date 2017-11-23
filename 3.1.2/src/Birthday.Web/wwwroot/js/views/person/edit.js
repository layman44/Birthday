(function ($) {

    $(function () {
        var _$form = $('#PersonEditForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                var input = _$form.serializeFormToObject();
                abp.services.app.personService.update(input)
                    .done(function () {
                        location.href = '/Birthday';
                    });
            });
        _$form.find('button[type=button]')
            .click(function (e) {
                location.href = "/Birthday";
            });
    });

})(jQuery);