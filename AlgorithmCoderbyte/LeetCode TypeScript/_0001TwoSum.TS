function twoSum(nums: number[], target: number): number[] {
    let ans: number[] = [];
    for (let i: number = 0; i < nums.length; i++) {
        if (i == nums.length - 1) break;
        for (let j: number = i + 1; j < nums.length; j++) {
            if (nums[i] + nums[j] == target) {
                ans.push(i);
                ans.push(j);
               return ans;
            }
        }
    }
    return ans;
};

type numberArrayOrNull = number[] | null;
function twoSumUsingMap(nums: number[], target: number): numberArrayOrNull {
    // Create a hash table to store the seen elements.
    const seen: Map<number, number> = new Map();

    // Iterate over the array.
    for (let i = 0; i < nums.length; i++) {
        // Calculate the complement of the current element.
        const complement = target - nums[i];

        // Check if the complement is in the hash table.
        if (seen.has(complement)) {
            // Return the indices of the two elements.
            return [i, seen.get(complement)!];
        }

        // Add the current element to the hash table.
        seen.set(nums[i], i);
    }

    // If we reach this point, there is no solution to the problem.
    return null;
}

let ans: number[] = twoSum([3, 4, 5, 2], 7);
ans.forEach(x => console.log(x) );