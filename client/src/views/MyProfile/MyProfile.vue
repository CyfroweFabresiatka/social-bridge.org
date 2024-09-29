<script setup lang="ts">
import { getUser } from '@/store/auth'
import { ref } from 'vue'
import MyCompany from './MyCompany.vue'
import MyNgo from './MyNgo.vue'
import { useMyComapnyQuery } from '@/data/organisations/company'
import { useMyNgoQuery } from '@/data/organisations/ngo'

const user = ref<string>(getUser())
const { data, isLoading } = user.value === 'Firma' ? useMyComapnyQuery() : useMyNgoQuery()
</script>

<template>
  <v-container>
    <h1>Moje info</h1>
    <my-company v-if="user === 'Firma' && data" :company="data"></my-company>
    <my-ngo v-if="user === 'Fundacja' && data" :ngo="data"></my-ngo>
  </v-container>
</template>

<style scoped></style>
