
describe("Binomial", function () {
    var n = 9;
    var binomial;
    beforeEach(function () {
        binomial = Binomial(n);
    });

    it("Check length of triangle", function () {
        expect(binomial.length).toEqual(n);
    });

    it("Check length of last row", function () {
        expect(binomial[n - 1].length).toEqual(n);
    });

    it("Check values last row", function () {
        expect(binomial[n - 1][0]).toEqual(1);
        expect(binomial[n - 1][1]).toEqual(8);
        expect(binomial[n - 1][2]).toEqual(28);
        expect(binomial[n - 1][3]).toEqual(56);
        expect(binomial[n - 1][4]).toEqual(70);
        expect(binomial[n - 1][5]).toEqual(56);
        expect(binomial[n - 1][6]).toEqual(28);
        expect(binomial[n - 1][7]).toEqual(8);
        expect(binomial[n - 1][8]).toEqual(1);
    });

    it("Check values left diagonal", function () {
        for (var i = 1; i < binomial.length; i++) {
            expect(binomial[i][1]).toEqual(i);
        }

    });

    it("Check values right diagonal", function () {
        for (var i = 1; i < binomial.length; i++) {
            var j = binomial[i].length - 2;
            expect(binomial[i][j]).toEqual(i);
        }

    });

});