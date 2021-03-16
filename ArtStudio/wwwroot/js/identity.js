function SendRequest(data) {
    return $.ajax({
        type: data.type,
        url: data.url,
        data: JSON.stringify(data.data),
        contentType: data.contentType
    }).done(function (result) {
        return result;
    }).fail(function (result) {
        return result;
    });
}