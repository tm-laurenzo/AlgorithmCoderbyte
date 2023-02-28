function twoSum(nums: number[], target: number): number[] {
    let ans: number[] = [];
    for (let i: number = 0; i < nums.length; i++) {
        if (i == nums.length - 1) break;
        for (let j: number = i + 1; j < nums.length; j++) {
            if (nums[i] + nums[j] == target) {
                ans.push(i);
                ans.push(j);
               
            }
        }
    }
    return ans;
};