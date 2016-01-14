function Binomial(rows) {

    var triangle = [
        [1]
    ]

    var row = [];

    for (var i = 0; i < rows - 1; i++) {
       
        row = [1];

        for (var j = 1; j < triangle[i].length; j++) {
            var n = i;
            var k = j;

            row[k] = triangle[n][k] + triangle[n][k - 1];
        }

        row.push(1);
        triangle.push(row);

    }

    return triangle;
}
