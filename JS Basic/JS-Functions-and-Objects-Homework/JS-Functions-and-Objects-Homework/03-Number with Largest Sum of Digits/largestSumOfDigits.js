function findLargestBySumOfDigits(nums) {

    var sum = 0;
    var element = -1;

    for (var i = 0; i < nums.length; i++) {

        var tmp_sum = 0;
        var re = new RegExp('-', 'g');
        var num = nums[i].toString().replace(re, '');

        for (j = 0; j < num.length; j++) {

            tmp_sum += parseInt(num[j]);
        }

        if (tmp_sum > sum) {
            sum = tmp_sum;
            element = i;
        }
        tmp_sum = 0;
    }

    console.log(nums[element]);

}

findLargestBySumOfDigits([5, 10, 15, 111]);
findLargestBySumOfDigits([33, 44, -99, 0, 20]);
findLargestBySumOfDigits(['hello']);
findLargestBySumOfDigits([5, 3.3]);