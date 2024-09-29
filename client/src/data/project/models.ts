import type { BudgetType } from '@/data/home'

export interface Project {
    budgetAmountFrom: number;
    budgetAmountTo: number;
    budgetType: number;
    createdAt: string;
    description: string;
    id: string;
    locations: string[];
    name: string;
    ngo: Ngo;
    plannedEndDate: Date;
    plannedStartDate: Date;
    slug: string;
    status: number;
    tags: string[];
}

export interface Ngo {
    id: string;
    name: string;
}

export interface CreateProjectReq {
    ngoId: string;
    name: string;
    slug: string;
    description: string;
    budgetAmountFrom: number;
    budgetAmountTo?: number;
    budgetType: BudgetType;
    plannedStartDate?: Date;
    plannedEndDate?: Date;
    locationsIds: number[];
    tagsIds: number[];
}
