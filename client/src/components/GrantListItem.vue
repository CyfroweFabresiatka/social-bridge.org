<script setup lang="ts">
import { BudgetType, type Grant } from '@/data/home'
import { computed } from 'vue'

const props = defineProps<{
  item: Grant
}>();

const budgetDescription = computed(() => {
  return `${props.item.budgetFrom} - ${props.item.budgetTo} zł`;
});
</script>

<template>
  <v-card class="item" variant="flat" border="border" :to="`/grants/${item.slug}`">
    <v-row>
      <v-col>
        <v-card-title>{{item.name}}</v-card-title>
        <v-card-text>{{item.companyName}}, {{item.city}}</v-card-text>
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
