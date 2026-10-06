class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        std::unordered_map<int,int> dict;
        for (auto i = 0uz; i < nums.size(); i++) {
            int comp = target - nums[i];
            if (!dict.contains(comp)) {
                dict.insert({nums[i], i});
            }
            else {
                return {dict.at(comp), static_cast<int>(i)};
            }
        }
        return {-1, -1};
    }
};
