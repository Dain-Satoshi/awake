var functions = {
    foo: function (arg0, arg1) {
        alert("foo called with " + arg0 + "," + arg1);
    },
    bar: function (arg) {
        alert("bar called with " + arg);
    }
};
$.ajax({
    url: "HelloWorld",
    dataType: "json",
    success: function (data) {
        if (data && data.fname && data.args) {
            functions[data.fname].apply(undefined, data.args);
        }
    }
});