<script setup lang="ts">
import { useCompaniesQuery, useNgosQuery } from '@/data/organisations'
import ProjectListItem from '@/components/ProjectListItem.vue'
import GrantListItem from '@/components/GrantListItem.vue'
import { ref } from 'vue'
import CompanyListItem from '@/components/CompanyListItem.vue'

const { companies } = useCompaniesQuery();
const { ngos } = useNgosQuery();
const tab = ref(1);
</script>

<template>
  <v-row>
    <v-col cols="3">
      <v-text-field
        variant="outlined"
        label="Szukaj"
        density="compact"
      />
    </v-col>
  </v-row>
  <v-row>
    <v-col>
      <v-tabs
        v-model="tab"
        color="secondary"
      >
        <v-tab :value="1">Firmy</v-tab>
        <v-tab :value="2">Fundacje</v-tab>
      </v-tabs>
    </v-col>
  </v-row>
  <v-row>
    <v-col>
      <v-tabs-window v-model="tab">
        <v-tabs-window-item :value="1">
          <CompanyListItem v-for="item in companies" :key="item.slug" :item="item" />
        </v-tabs-window-item>
        <v-tabs-window-item :value="2">
          <CompanyListItem v-for="item in ngos" :key="item.slug" :item="item" />
        </v-tabs-window-item>
      </v-tabs-window>
    </v-col>
  </v-row>
</template>

<style scoped>
</style>
