<script setup lang="ts">
import { useCompaniesQuery, useNgosQuery } from '@/data/organisations'
import { ref } from 'vue'
import CompanyListItem from '@/components/CompanyListItem.vue'
import NgoListItem from '@/components/NgoListItem.vue'

const { companies } = useCompaniesQuery();
const { ngos } = useNgosQuery();
const tab = ref(1);
</script>

<template>
  <v-row>
    <v-col cols="3">
      <v-text-field
        prepend-inner-icon="mdi-magnify"
        label="Szukaj"
        density="compact"
        variant="solo-filled"
        rounded="pill"
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
          <NgoListItem v-for="item in ngos" :key="item.slug" :item="item" />
        </v-tabs-window-item>
      </v-tabs-window>
    </v-col>
  </v-row>
</template>

<style scoped>
</style>
