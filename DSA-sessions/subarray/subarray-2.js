// Printing all subarray sum

function printAllSubarray(arr) {
  for (let s = 0; s < arr.length; s++) {
    let sum = 0;
    for (let e = s; e < arr.length; e++) {
      // for (let i = s; i <= e; i++) {
      sum = sum + arr[e];
      console.log(sum)
      // }
    }
    // return sum
  }
}

printAllSubarray([3, 4, 2])

function printAllSubarraysum(arr) {
  let n = arr.length;
  let totalSum = 0;
  for (let s = 0; s < n; s++) {
    let sum = 0;
    for (let e = s; e < n; e++) {
      sum = sum + arr[e]
      console.log(sum)
      totalSum = totalSum + sum;
    }
  }
  return totalSum
}

console.log(printAllSubarraysum([3, 4, 2]))


// Contribution Technique===>
function subarraySumBycontribution(arr) {
  let n = arr.length;
  let totalsum = 0

  for (let i = 0; i < n; i++) {
    let sum = 0;
    let accorance = (i + 1) * (n - i);

    sum = accorance * arr[i];
    console.log(accorance)
    console.log(sum)
    totalsum += sum
  }
  return totalsum;
}

console.log(subarraySumBycontribution([2, 8, -1, 4]))