function calsum(arr, q){
  let result= [];
  for(let i=0; i< q.length; i++){
    let sum = 0;
    let L = q[i][0];
    let R = q[i][1];
    console.log(L,R)

    for(let j= L; j <= R; j++){
       sum =  sum + arr[j];
    }
    result.push(sum)
  }
 return result
}
 
console.log(calsum([1,2,3,4,5,6,7],[[2,3], [4,5]]))


// for(let i = 0; i <= 7; i++){
//   let sum= 0;
//   sum = sum + i
// }



// MAX_VALUE = 1.7976931348623157e+308  in javascript
// MAX_VALUE = 9,223,372,036,854,775,807 in java