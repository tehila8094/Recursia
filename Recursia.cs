const names = [["a", "b", "c"], ["d"], ["e", "f", "g"]]
const coins = [1, 5, 6];
// let userInput = window.prompt("Please enter your input:");
// console.log("User input:", userInput);

let m = 3;
// let n = 5;
const mat = [[2, 3], [2, 3]];
const mat1 = [9, 9, 12, 3, 3, 18, 18, 6, 6];
const mat2 = [4, 5, 5, 10, 10, 7, 7];
const mat3 = [3, 40, 23, 41, 53, 43, 100, 45, 111, 50];
const mat4 = [7, 28, 70, 21, 700, 10, 7000, 1]
const arr = [1, 2, 3, 3, 3, 4, 5];
let iS = 0, iE = 0;


function calcOptionsD(meters){
    if (meters==1)
    return 1;
let m1=1,m2=0,t=0;
for (let index = 2; index <= meters; index++) {
    t=m2;
    m2=m1;
    m1+=t;
}
return m1+m2;
}
function calcOptions(meters){
    if (meters==1)
    return 1;
    if(meters==2)
    return 2;
return calcOptions(meters-2)+calcOptions(meters-1)
}
function calcOptions3(meters){
    if (meters==1)
    return 1;
    if(meters==2)
    return 3;
return calcOptions3(meters-1)+calcOptions3(meters-2)+1;
}
function subSum(arr,sum){
if(sum==0)
return true;
else if(arr.length==0)
return false;
return subSum(arr.slice(1),sum-arr[0])||subSum(arr.slice(1),sum);

}

function countPairs(n,s,r,l){
if(s.length==n*2){
    console.log(s)
    return 1;
}
if(r==l)
   return countPairs(n,s+"(",r+1,l)
if(r==n)
return countPairs(n,s+")",r,l+1)
return countPairs(n,s+")",r,l+1)+countPairs(n,s+"(",r+1,l)
}
const mat5=[
    [0 ,1 ,1, 1],
    [1, 0 ,1, 1],
    [1, 1 ,0 ,1],
    [1 ,1 ,1 ,0]
]

const mat6=[
[0 ,1 ,0, ,0, ,0, 1, 1, 0, 0, 0],
 [1 ,0 ,1 ,1 ,0 ,0 ,0 ,0 ,0 ,1],
 [0, 1, 0, 0, 0, 1, 1, 0, 0, 1],
 [0, 1, 0, 0, 0, 0, 1, 1, 0, 0],
 [0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
 [1, 0, 1, 0, 0, 0, 0, 1, 1, 0],
 [1, 0, 1, 1, 0, 0, 0, 1, 1, 0],
 [0, 0, 0, 1, 0, 1, 1, 0, 0, 1],
 [0, 0, 0, 0, 0, 1, 1, 0, 0, 0],
 [0, 1, 1, 0, 1, 0, 0, 1, 0, 0],
]

function friend3(mat,i,j,third){
    if(i>=mat.length-2)
       return 0;
    if(j>=mat.length-1)
       return friend3(mat,i+1,i+2,i+3);
    if(third>=mat.length)
       return friend3(mat,i,j+1,j+2)
    if (mat[i][j] == 1 && mat[i][third] == 1 && mat[j][third] == 1) 
    {
        console.log(i+","+j+","+third);
        return friend3(mat,i,j,third+1)+1;
    }
    return friend3(mat,i,j,third+1);
}


// function friend3(mat,i,j,second,count){
//     if(i==mat.length)
//     return 0;
//     if(j==mat.length)

// return friend3(mat,i+1,i+2,second,1)+ friend3(mat,i,second+2,second+1,1);
//     if(mat[i,j]=1&&i!=j)
//     {
//         if(count ==1)
//          return friend3(mat,i,j+1,j,count+1);
//         if(count==2){
//             if(mat[j,second]=1){
//             console.log(i+","+second+","+j)
//             mat[i,j]=0;
//             mat[j,second]=0;
//             return friend3(mat,i,j+1,second,count)+1;
//             }
//             return friend3(mat,i,j+1,second,count);
//         }
//     }
//     else
//       return friend3(mat,i,j+1,second,count);
// }

// console.log(countPairs(3,"",0,0,3))
console.log(friend3(mat6,0,1,2))

function f(m,n){
if(m==0)
return 1;
if(m<0)
return 0;
if(n==0)
return 1;
return f(m-n,n-1)+f(m-n-1,n-1);
}
// console.log(f(6,3));


// 0 1 2
//  0 1 3
//  0 2 3
//  1 2 3
  // הדוגמה שלך
 
// const arr2=[12,5,2]
// console.log(calcOptionsD(5))
// console.log(calcOptions(5))
//  console.log(calcOptions3(5))
// console.log(subSum(arr2,8))




// function findSumTogether(mat3,x,length){
//     if(x==0)
//     return true;
//     if()
//     findSumTogether(mat3,x-mat)
//     findSumTogether(mat3,)
// }

function findX(mat3, x, begin, end) {
    if (end <= begin)
        return;
    if (x == mat3[(end - begin / 2) + begin])
        return true;
    if ((end - begin / 2) + begin % 2 == 0) {
        if (x > mat3[(end - begin / 2) + begin])
            return findX(mat3, x, (end - begin / 2) + begin, end)
        else
            return findX(mat3, x, begin, (end - begin / 2) + begin)
        findX(mat3, x, (end - begin / 2) + begin + 1, end)
    }
    else {
        if (x < mat3[(end - begin / 2) + begin])
            return findX(mat3, x, (end - begin / 2) + begin + 2, end)
        else
            return findX(mat3, x, begin, (end - begin / 2) + begin - 2)
    }
}

function calcMinCoins(coins, x) {
    const sum = new Array(x + 1);
    let min = Number.MAX_VALUE;
    for (let i = 1; i < sum.length; i++) {
        for (let j = 0; j < coins.length; j++) {
            if (i == coins[j]) {
                sum[i] = 1;;
                break;
            }
            else {
                if (coins[j] < i) {
                    if (sum[i - coins[j]] + sum[coins[j]] < min) {
                        min = sum[i - coins[j]] + sum[coins[j]];
                        sum[i] = min;
                    }
                }
            }
        }
        min = Number.MAX_VALUE;
    }
    let min2 = Number.MAX_VALUE;
    let id = 0;
    for (let i = x; i > 0;) {
        if (sum[i] == 1) {
            console.log(i)
            break;
        }
        else {
            for (let j = 0; j < coins.length; j++) {
                if (sum[i - coins[j]] < min2) {
                    min2 = sum[i - coins[j]];
                    id = i - coins[j];
                }
            }
        }
        i = id;
        console.log(i)
    }
    return sum[x];
}

function findAbsentNum(mat1, begin, end) {
    middle = (end - begin) / 2 + begin;
    if (begin >= end)
        // return;
        return mat1[middle];
    if ((middle) % 2 == 0) {
        if (mat1[middle - 1] == mat1[middle])
            return findAbsentNum(mat1, begin, middle - 2)
        else
            return findAbsentNum(mat1, middle + 2, end)
    }
    else {
        if (mat1[middle - 1] == mat1[middle])
            return findAbsentNum(mat1, begin + 1, end)
        else
            return findAbsentNum(mat1, begin, middle - 1)
    }
    //  return mat1[middle];
}

function kamehaDinami(mat, m, n) {
    if (m == 0 || n == 0)
        return 1;
    mat[m, n] = kamehaDinami(mat, m - 1, n) + kamehaDinami(mat, m, n - 1);
    return mat[m, n];
}

function printAllNames(names, index = 0, concatname = '') {
    if (index == names.length) {
        console.log(concatname)
        return;
    }
    for (let name of names[index]) {
        printAllNames(names, index + 1, concatname + ' ' + name)
    }
}

function longestWord(word1,word2){
   if(word1.length==0||word2.length==0)
   return 0;
   if(word1[0]==word2[0])
   return longestWord(word1.slice(1),word2.slice(1))+1;
   else
   return Math.max( longestWord(word1,word2.slice(1)),longestWord(word1.slice(1),word2));
}

// printAllNames(names);
// console.log(findAbsentNum(mat2, 0, mat2.length - 1))
// console.log(kamehaDinami(mat, m - 1, n - 1))
// console.log(calcMinCoins(coins, 10))
// console.log(findSumTogether(mat3, 145))
// console.log(findX(mat4,70,0,mat4.length-1))

// console.log(longestWord("a","b"));
// console.log(longestWord("abcbdaf","bdcaba"));

function fibonacciDynamic(n) {
    let fib = [0, 1]; // Initialize the first two Fibonacci numbers
    for (let i = 2; i <= n; i++) {
        fib.push(fib[i - 1] + fib[i - 2]); // Calculate the next Fibonacci number
    }
    return fib[n];
}
// let mid, sum = 0;




function timesOfNum(arr, b, e, num) {
    // mid = (e - b) / 2 + b;
    // if (arr[mid] == num) {
    //     if (arr[mid - 1] == num)
    //         iS = timesOfNum(arr, b, mid - 1, num)
    //     else
    //         iS = mid;
    // }
    // if (arr[mid + 1] == num)
    //     iE = timesOfNum(arr, mid + 1, e, num)
    // else
    //     iE = mid;
    // return ie - iS;

}

function timesOfNum(arr, b, e, num) {
    if (e < b)
        return 0;
    if (arr[mid] == num) {
        // if (arr[mid + 1] == num)
        return timesOfNum(arr, mid + 1, e, num) + timesOfNum(arr, b, mid - 1, num) + 1;
        // if (arr[mid - 1] == num)
        // return timesOfNum(arr, b, mid - 1, num);
        // return 1;
    }
    else if (arr[(e - b) / 2 + b] > num)
        timesOfNum(arr, b, mid - 1, num);
    else
        timesOfNum(arr, mid + 1, e, num);
    // return;

    // if (arr[mid] == num) {
    //     if (arr[mid - 1] == num)
    //         iS = timesOfNum(arr, b, mid - 1, num)
    //     else
    //         iS = mid;

    //     if (arr[mid + 1] == num)
    //         iE = timesOfNum(arr, mid + 1, e, num)
    //     else
    //         iE = mid;
    //     return iE - iS;
    // }
}



//  console.log(timesOfNum(arr, 0, arr.length - 1, 3));


//console.log(fibonacciDynamic(6)); // Output: 8

function findRange(arr, number, low, high) {
    if (low > high) {
      return [-1, -1];
    }
  
    let mid = Math.floor((low + high) / 2);
  
    if (arr[mid] === number) {
      // חותך את המחצית הימנית של המערך
      const left = findRange(arr, number, low, mid - 1);
  
      // חותך את המחצית השמאלית של המערך
      const right = findRange(arr, number, mid + 1, high);
  
      // מחזיר את האינדקסים של התחלה וסיום הרצף
      return [left[0] === -1 ? mid : left[0], right[1] === -1 ? mid : right[1]];
    } else if (arr[mid] < number) {
      return findRange(arr, number, mid + 1, high);
    } else {
      // חותך את המחצית השמאלית של המערך
      return findRange(arr, number, low, mid - 1);
    }
  }
//   const mj=findRange(arr, 3, 0, arr.length - 1); // 4
//   console.log(mj[1]-mj[0]+1)

//   function findRange(arr, number, low, high) {
//     if (low > high) {
//       return 0;
//     }
  
//     let mid = Math.floor((low + high) / 2);
  
//     if (arr[mid] === number) {
//       // חותך את המחצית הימנית של המערך
//       let count = 1;
//       while (arr[mid + 1] === number) {
//         count++;
//         mid++;
//       }
//       if (mid === arr.length - 1) {
//         return count;
//       } else {
//         return count + findRange(arr, number, mid + 1, high);
//       }
//     } else if (arr[mid] < number) {
//       return findRange(arr, number, mid + 1, high);
//     } else {
//       // חותך את המחצית השמאלית של המערך
//       return findRange(arr, number, low, mid - 1);
//     }
//   }
  
//   const arr = [1, 2, 3, 3, 3, 4, 5];
//   console.log(findRange(arr, 3, 0, arr.length - 1));