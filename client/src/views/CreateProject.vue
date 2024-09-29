<script setup lang="ts">
import { ref } from 'vue'
import { useProjectMutation } from '@/data/project/project'
import { BudgetType } from '@/data/home'
//import { getUser, getGuid} from '@/store/auth'

// const user = ref<string>(getUser())
// const ngoId = ref<string>(getGuid())

const { addMutationFn } = useProjectMutation()

const name = ref<string>('')
const slug = ref<string>('')
const description = ref<string>('')
const budgetAmountFrom = ref<number>(0)
const budgetAmountTo = ref<number>(0)
const plannedStartDate = ref<any>('')
const plannedEndDate = ref<any>('')
const locationsIds = ref<number[]>([0,1])
const tagsIds = ref<number[]>([0,1])

function valid() {
  return name.value.trim() !== ''
}

async function onSubmit() {
  alert(plannedStartDate.value);
  await addMutationFn({
    ngoId : "",
    name : name.value,
    slug : slug.value,
    description : description.value,
    budgetAmountFrom : budgetAmountFrom.value,
    budgetAmountTo : budgetAmountTo.value,
    plannedStartDate : plannedStartDate.value,
    plannedEndDate : plannedEndDate.value,
    locationsIds : locationsIds.value,
    tagsIds : tagsIds.value,
    budgetType: BudgetType.Money,
  })
  name.value = ''
}
</script>

<template>
  <v-form :value="valid()">
    <v-row>
      <v-col class="pb-0">
        <v-text-field v-model="name" name="name" :label="$t('project.project_name')" />
        
        <v-form>
          <v-text-field v-model="slug" label="Slug" outlined/>
          <v-textarea v-model="description" label="Description" outlined/>
          <v-text-field v-model="budgetAmountFrom" label="Budget Amount From" type="number" outlined/>
          <v-text-field v-model="budgetAmountTo" label="Budget Amount To" type="number" outlined/>
          <v-date-picker></v-date-picker>
        </v-form>
        
      </v-col>
    </v-row>
    <v-row>
      <v-spacer />
      <v-btn color="primary" small :disabled="!valid()" @click="onSubmit">
        <v-icon icon="mdi-plus"></v-icon>
        {{ $t('project.addProject') }}
      </v-btn>
    </v-row>
  </v-form>
</template>

<style scoped>
</style>
