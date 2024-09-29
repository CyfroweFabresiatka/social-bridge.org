<script setup lang="ts">
import type { Company } from '@/data/organisations'

const props = defineProps<{
  item: Company
}>();
</script>

<template>
  <v-card class="item" variant="flat" border="border" :to="`/ngo/${item.slug}`">
    <v-row>
      <v-col>
        <v-card-title>{{item.name}}</v-card-title>
        <v-card-text>{{item.city}}</v-card-text>
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
