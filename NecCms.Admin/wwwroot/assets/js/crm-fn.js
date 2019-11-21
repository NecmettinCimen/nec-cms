

(function ($) {
    $.fn.serializeFormJSON = function () {

        var o = {};
        var a = this.serializeArray();

        $.each(a, function () {
            var name = this.name;

            var value = this.value;

            var formElement = tpage.form.find(f => f.id === name);

            if (formElement) {
                if (formElement.type === 'select') {
                    value = parseInt(value);
                    if (formElement.boolean) {
                        value = value ? true : false
                    }
                } else if (formElement.type === 'input' && formElement.subtype) {
                    if (formElement.subtype.startsWith('number')) {
                        if (formElement.subtype.endsWith('int')) {
                            value = parseInt(value)
                        } else {
                            value = parseFloat(value)
                        }
                    }
                } else if (formElement.type == 'date') {
                    if (value)
                        value = formatDateIso(value);
                    else
                        value = null
                } else if (formElement.type == 'datetime') {
                    if (value) {
                        var saat = parseInt($('#saat_' + name).val());
                        var dakika = parseInt($('#dakika_' + name).val());
                        value = formatDateIso(value) + `T${saat < 10 ? "0" + saat : saat}:${dakika < 10 ? "0" + dakika : dakika}:00.0000`;
                    }
                    else
                        value = null
                }

            }


            if (o[name]) {
                if (!o[name].push) {
                    o[name] = [o[name]];
                }
                o[name].push(value);
            } else {
                o[name] = value;
            }
        });
        return o;
    };
})(jQuery);