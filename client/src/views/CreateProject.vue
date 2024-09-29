<script setup lang="ts">
import { ref } from 'vue'
import { useProjectMutation } from '@/data/project/project'
import { getUser, getGuid} from '@/store/auth'

const user = ref<string>(getUser())
const guid = ref<string>(getGuid())

const { addMutationFn } = useProjectMutation()

const ngoId = ref<string>(guid)
const name = ref<string>('')
const slug = ref<string>('')
const description = ref<string>('')
const budgetAmountFrom = ref<number>('')
const budgetAmountTo = ref<number>('')
const plannedStartDate = ref<any>('')
const plannedEndDate = ref<any>('')
const locationsIds = ref<string>([0,1])
const tagsIds = ref<string>([0,1])

function valid() {
  return name.value.trim() !== ''
}

async function onSubmit() {
  alert(plannedStartDate.value);
  await addMutationFn({
    ngoId : "",
    name : name,
    slug : slug,
    description : description,
    budgetAmountFrom : budgetAmountFrom,
    budgetAmountTo : budgetAmountTo,
    plannedStartDate : plannedStartDate,
    plannedEndDate : plannedEndDate,
    locationsIds : locationsIds,
    tagsIds : tagsIds,
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
