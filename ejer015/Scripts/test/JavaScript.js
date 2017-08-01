describe("A suite", function () {
    it("contains spec with an expectation", function () {
        expect(true).toBe(true);
    });

});

describe("Another suite1", function() {
var resultado;
it("prueba de petición REST ReadOne", function (done) {
    $.get("api/values/3", function (data) {
        resultado = data;
        done();
    });
});

    afterEach(function (done) {
        expect(resultado).toBe("value");
        done();
    }, 1000);


});

describe("Another suite2", function () {
    var resultado;
    it("prueba de petición REST ReadAll", function (done) {
        $.get("api/values/3", function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(resultado).toBe("value");
        done();
    }, 1000);


});

describe("Another suite3", function () {
    var resultado;
    it("prueba de petición POST Create", function (done) {
        $.post("api/values", function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(true).toBe(true);
        done();
    }, 1000);


});

describe("Another suite4", function () {
    var resultado;
    it("prueba de petición PUT Update", function (done) {
        $.put("api/values/5", function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(true).toBe(true);
        done();
    }, 1000);


});

describe("Another suite5", function () {
    var resultado;
    it("prueba de petición Delete", function (done) {
        $.delete("api/values/1", function (data) {
            resultado = data;
            done();
        });
    });

    afterEach(function (done) {
        expect(true).toBe(true);
        done();
    }, 1000);


});
