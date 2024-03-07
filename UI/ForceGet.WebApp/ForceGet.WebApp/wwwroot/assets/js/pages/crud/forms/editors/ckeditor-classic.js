"use strict";
// Class definition

var KTCkeditor = function () {
    // Private functions
    var demos = function () {

        ClassicEditor
            .create(document.querySelector('#editor'), {
                cloudServices: {
                    tokenUrl: '',
                    uploadUrl: '~/Files/'
                }
            }
            )
            .then(editor => {
                console.log(editor);
            })
            .catch(error => {
                console.error(error);
            });
    }


    return {
        // public functions
        init: function () {
            demos();
        }
    };
}();

// Initialization
jQuery(document).ready(function () {
    KTCkeditor.init();

});