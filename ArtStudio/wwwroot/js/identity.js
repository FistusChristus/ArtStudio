function SendRequest(data) {
    console.log(data);
    return $.ajax({
        type: data.type,
        url: data.url,
        data: JSON.stringify(data.data),
        contentType: data.contentType
    }).done(function (result) {
        console.log(result);
        return result;
    }).fail(function (result) {
        console.log(result);
        return result;
    });
}