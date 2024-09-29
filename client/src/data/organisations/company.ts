import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'

export const useMyComapnyQuery = () => {
  const fetch = useFetch()
  const { data, isLoading } = createQuery<Company>(['my-company'], () =>
    fetch.get<Company>('/api/v1/companies/my')
  )

  return { data, isLoading }
}

export interface Company {
  name: string
  description: string
  location: string
  tags: string[]
}
