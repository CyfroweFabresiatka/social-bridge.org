import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'

export const useProjectsQuery = () => {
  const fetch = useFetch();
  const { data: projects, isLoading } = createQuery(
    ['home-projects'],
    () => fetch.get<Project[]>('/api/v1/projects')
  );
  
  return { projects, isLoading };
}

export const useGrantsQuery = () => {
  //const fetch = useFetch();
  const { data: grants, isLoading } = createQuery(
    ['home-grants'],
    () => loadGrants()
  );

  return { grants, isLoading };
}

async function loadGrants() {
  const grants = await import('./grants.json');
  return <Grant[]>grants.default;
}

export interface Project {
  name: string;
  slug: string;
  city: string;
  budgetType: BudgetType;
  budgetAmountFrom: number;
  budgetAmountTo?: number;
  ngoName: string;
}

export interface Grant {
  name: string;
  slug: string;
  city: string;
  budgetFrom: number;
  budgetTo: number;
  companyName: string;
}

export enum BudgetType {
  Money = 'Money',
  People = 'People',
}
