from typing import List
def twoSum(self, nums: List[int], target: int) -> List[int]:
        num_hash = {}
        for i in range(len(nums)):
            if target - nums[i] in num_hash:
                return [num_hash[target - nums[i]], i] #có thể return None 
            num_hash[nums[i]] = i