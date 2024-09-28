<script setup lang="ts">
import { BudgetType, type Project } from '@/data/home'
import { computed } from 'vue'

const props = defineProps<{
  item: Project
}>();

const budgetDescription = computed(() => {
  if (props.item.budgetType === BudgetType.Money) {
    return `${props.item.budgetAmountFrom} - ${props.item.budgetAmountTo} zł`;
  }

  if (props.item.budgetType === BudgetType.People) {
    return `${props.item.budgetAmountFrom} wolontariuszy`;
  }
  
  return  '';
});
</script>

<template>
  <v-card class="item" variant="flat" border="border" :to="`/projects/${item.slug}`">
    <v-row>
      <v-col>
        <v-card-title>{{item.name}}</v-card-title>
        <v-card-text>{{item.city}}</v-card-text>
      </v-col>
      <v-col>
        <v-card-text>{{budgetDescription}}</v-card-text>
      </v-col>
    </v-row>
  </v-card>
</template>

<style scoped lang="scss">
.item {
  margin-bottom: 10px;
  cursor: pointer;
}
</style>
